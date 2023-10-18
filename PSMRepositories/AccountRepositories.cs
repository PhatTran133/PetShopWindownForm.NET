using BuisinessObject;
using PSMDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PSMRepositories
{
    public class AccountRepository : IAccountRepository
    {
        Accounts IAccountRepository.GetAccountByEmail(string username) => AccountDAO.Instance.GetAccountByUsername(username);
        List<Accounts> IAccountRepository.GetAllAccount() => AccountDAO.Instance.GetAllAccounts();
        void IAccountRepository.CreateAccount(Accounts account) => AccountDAO.Instance.CreateAccount(account);
        void IAccountRepository.EditAccount(Accounts account) => AccountDAO.Instance.EditAccount(account);
        void IAccountRepository.RemoveAccount(string id) => AccountDAO.Instance.RemoveAccount(id);
        List<string> IAccountRepository.GetAllRoles() => AccountDAO.Instance.GetAllRoles();
    }
}
