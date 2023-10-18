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
    public partial class PetsView : Form
    {
        private IPetRepositories petRepositories;
        public PetsView()
        {
            InitializeComponent();
            petRepositories = new PetRepositories();
            dtg_PestsList.DataSource = petRepositories.GetAllPets();
        }

        private void txt_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Search.Text.Trim()))
                {
                    MessageBox.Show("Please Enter Name");
                }

                dtg_PestsList.DataSource = petRepositories.GetPetByName(txt_Name.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Cannot Find Pet");
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
