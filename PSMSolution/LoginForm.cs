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
    public partial class LoginForm : Form
    {
        private IAccountRepository accountRepository;
        public LoginForm()
        {
            InitializeComponent();
            accountRepository = new AccountRepository();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Accounts account = accountRepository.GetAccountByEmail(txt_Username.Text.Trim());
            if (account != null && txt_Password.Text.Trim() == account.Password)
            {
                switch (account.Role)
                {
                    case 1:
                        AccountsManagement accountsManagement = new AccountsManagement();
                        this.Hide();
                        accountsManagement.ShowDialog();
                        this.Show();
                        break;
                    case 2:
                        PetsManagement petsManagement = new PetsManagement();
                        this.Hide();
                        petsManagement.ShowDialog();
                        this.Show();
                        break;
                    case 3:
                        PetsView petsView = new PetsView();
                        this.Hide();
                        petsView.ShowDialog();
                        this.Show();
                        break;
                    default:
                        MessageBox.Show("You dont have permission");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please check Username and Password");
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
