using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisinessObject
{
    public class Accounts
    {
        private string id;
        private string userName;
        private string password;
        private int role;

        public Accounts(string id, string userName, string password, int role)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.role = role;
        }

        public string Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int Role { get => role; set => role = value; }
    }
    public class Role
    {
        public string role;
    }
}
