using BuisinessObject;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Reflection.PortableExecutable;
using System.Security.Principal;

namespace PSMDAO
{
    public class AccountDAO
    {
        private static AccountDAO instance = null;
        private static string filePathAccounts = "C:\\Visual Studio\\PSMSolution\\PSMData\\PSMAccounts.json";
        private static string filePathRoles = "C:\\Visual Studio\\PSMSolution\\PSMData\\PSMRoles.json";

        private AccountDAO()
        {
        }

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
        }

        public Accounts GetAccountByUsername(string username)
        {
            try
            {
                if (File.Exists(filePathAccounts))
                {
                    using (StreamReader reader = new StreamReader(filePathAccounts))
                    {
                        string json = reader.ReadToEnd();
                        dynamic data = JsonConvert.DeserializeObject(json);

                        List<Accounts> accountList = new List<Accounts>();

                        foreach (var account in data.Accounts)
                        {
                            accountList.Add(new Accounts(account.Id.ToString(), account.UserName.ToString(), account.Password.ToString(), Convert.ToInt32(account.Role)));
                        }

                        Accounts accountSearch = accountList.FirstOrDefault(a => a.UserName == username);

                        if (accountSearch != null)
                        {
                            return accountSearch;
                        }
                    }
                }
                else
                {
                    throw new FileNotFoundException("File not found.", filePathAccounts);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return null;
        }
        public List<Accounts> GetAllAccounts()
        {
            try
            {
                if (File.Exists(filePathAccounts))
                {
                    List<Accounts> accountList = new List<Accounts>();

                    using (StreamReader reader = new StreamReader(filePathAccounts))
                    {
                        string json = reader.ReadToEnd();
                        dynamic data = JsonConvert.DeserializeObject(json);

                        foreach (var account in data.Accounts)
                        {
                            accountList.Add(new Accounts(account.Id.ToString(), account.UserName.ToString(), account.Password.ToString(), Convert.ToInt32(account.Role)));
                        }
                    }
                    return accountList;
                }
                else
                {
                    throw new FileNotFoundException("File not found.", filePathAccounts);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return null;
        }
        public void CreateAccount(Accounts account)
        {
            try
            {
                string id = null;
                int maxNumber = 0;
                int role = 3;
                List<Accounts> accountList = GetAllAccounts();
                Accounts newAccount = null;

                if (accountList.Count == 0)
                {
                    id = "A001";
                    role = 1;
                }

                bool flag = false;
                foreach(var existingAccount  in accountList)
                {
                    if (existingAccount.Id == account.Id || existingAccount.UserName == account.UserName)
                    {
                        flag = true;
                        break;
                    }
                    int number;
                    if (int.TryParse(existingAccount.Id.Substring(1), out number))
                    {
                        if (number > maxNumber)
                        {
                            maxNumber = number;
                        }
                    }
                }

                if(account.Id != null) {
                    id = account.Id.ToString();
                    
                }
                id = "C" + (maxNumber + 1).ToString("D3");

                if (account.Role != 0)
                {
                    role = account.Role;
                }

                if (flag)
                {
                    throw new Exception("Id or Username is duplicated");
                }
                else
                {
                    newAccount = new Accounts(
                        id,
                        account.UserName,
                        account.Password,
                        role
                    );
                }
                
                accountList.Add(newAccount);

                // Convert accountList to JSON and write it back to the file
                string json = JsonConvert.SerializeObject(new { Accounts = accountList });
                File.WriteAllText(filePathAccounts, json);
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating account: " + ex.Message);
            }
        }
        public void EditAccount(Accounts account)
        {
            try
            {
                List<Accounts> accountList = GetAllAccounts();

                // Find the account with the same ID and update its properties
                Accounts existingAccount = accountList.FirstOrDefault(a => a.Id == account.Id);
                if (existingAccount != null)
                {
                    existingAccount.UserName = account.UserName;
                    existingAccount.Password = account.Password;
                    existingAccount.Role = account.Role;
                }
                else
                {
                    throw new Exception("Account not found.");
                }

                // Convert accountList to JSON and write it back to the file
                string json = JsonConvert.SerializeObject(new { Accounts = accountList });
                File.WriteAllText(filePathAccounts, json);
            }
            catch (Exception ex)
            {
                throw new Exception("Error editing account: " + ex.Message);
            }
        }
        public void RemoveAccount(string id)
        {
            try
            {
                List<Accounts> accountList = GetAllAccounts();

                // Find the account with the specified ID and remove it from the list
                Accounts accountToRemove = accountList.FirstOrDefault(a => a.Id == id);
                if (accountToRemove != null)
                {
                    accountList.Remove(accountToRemove);
                }
                else
                {
                    throw new Exception("Account not found.");
                }

                // Convert accountList to JSON and write it back to the file
                string json = JsonConvert.SerializeObject(new { Accounts = accountList });
                File.WriteAllText(filePathAccounts, json);
            }
            catch (Exception ex)
            {
                throw new Exception("Error removing account: " + ex.Message);
            }
        }
        public List<string> GetAllRoles()
        {
            try
            {
                if (File.Exists(filePathRoles))
                {
                    List<string> rolesList = new List<string>();

                    using (StreamReader reader = new StreamReader(filePathRoles))
                    {
                        string json = reader.ReadToEnd();
                        dynamic data = JsonConvert.DeserializeObject(json);

                        foreach (var role in data.Roles)
                        {
                            rolesList.Add(role.role.ToString());
                        }
                    }
                    return rolesList;
                }
                else
                {
                    throw new FileNotFoundException("File not found.", filePathRoles);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return null;
        }
    }
}