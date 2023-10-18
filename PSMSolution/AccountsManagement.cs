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
    public partial class AccountsManagement : Form
    {
        private IAccountRepository accountRepository;
        public AccountsManagement()
        {
            InitializeComponent();
            accountRepository = new AccountRepository();
            dtg_AccountsList.DataSource = accountRepository.GetAllAccount();
            cmb_Role.Items.AddRange(accountRepository.GetAllRoles().ToArray());
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                int role = 0;
                if (cmb_Role.Text == "Admin")
                {
                    role = 1;
                }
                else if (cmb_Role.Text == "Manager")
                {
                    role = 2;
                }
                else if (cmb_Role.Text == "Customer")
                {
                    role = 3;
                }

                Accounts account = new Accounts(
                    txt_Id.Text.Trim(),
                    txt_Username.Text.Trim(),
                    txt_Password.Text.Trim(),
                    role
                    );
                accountRepository.CreateAccount(account);

                dtg_AccountsList.DataSource = accountRepository.GetAllAccount();
            }
            catch
            {
                MessageBox.Show("Cannot Create Account");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                int role = 0;
                if (cmb_Role.Text == "Admin")
                {
                    role = 1;
                }
                else if (cmb_Role.Text == "Manager")
                {
                    role = 2;
                }
                else if (cmb_Role.Text == "Customer")
                {
                    role = 3;
                }

                Accounts account = new Accounts(
                    txt_Id.Text.Trim(),
                    txt_Username.Text.Trim(),
                    txt_Password.Text.Trim(),
                    role
                    );
                accountRepository.EditAccount(account);

                dtg_AccountsList.DataSource = accountRepository.GetAllAccount();
            }
            catch
            {
                MessageBox.Show("Cannot Edit Account");
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txt_Id.Text.Trim();
                accountRepository.RemoveAccount(id);
                dtg_AccountsList.DataSource = accountRepository.GetAllAccount();
            }
            catch
            {
                MessageBox.Show("Cannot Remove Account");
            }
        }
    }
}
