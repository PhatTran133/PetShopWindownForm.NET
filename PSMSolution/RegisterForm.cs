using BuisinessObject;
using PSMRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSMAPP
{
    public partial class RegisterForm : Form
    {
        private IAccountRepository accountRepository;
        public RegisterForm()
        {
            InitializeComponent();
            accountRepository = new AccountRepository();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                Accounts account = new Accounts(
                    null,
                    txt_Username.Text.Trim(),
                    txt_Password.Text.Trim(),
                    0
                    );; 
                accountRepository.CreateAccount(account);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Cannot Create Account");
            }
        }
    }
}
