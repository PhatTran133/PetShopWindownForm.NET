using BuisinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PSMRepositories
{
    public interface IAccountRepository
    {
        Accounts GetAccountByEmail(string username);
        List<Accounts> GetAllAccount();
        void CreateAccount(Accounts account);
        void EditAccount(Accounts account);
        void RemoveAccount(string id);
        List<string> GetAllRoles();
    }
}
