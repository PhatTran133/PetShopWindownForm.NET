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
    public partial class PetsManagement : Form
    {
        private IPetRepositories petRepositories;
        public PetsManagement()
        {
            InitializeComponent();
            petRepositories = new PetRepositories();
            dtg_PetsList.DataSource = petRepositories.GetAllPets();
            cmb_Type.Items.AddRange(petRepositories.GetAllTypes().ToArray());
            cmb_Breed.Items.AddRange(petRepositories.GetAllBreedDogs().ToArray());
            cmb_Breed.Items.AddRange(petRepositories.GetAllBreedCats().ToArray());
        }

        private void cmb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cmb_Type.SelectedItem.ToString();

            if (selectedType == "Dog")
            {
                cmb_Breed.Items.Clear();
                cmb_Breed.Items.AddRange(petRepositories.GetAllBreedDogs().ToArray());
            }
            else if (selectedType == "Cat")
            {
                cmb_Breed.Items.Clear();
                cmb_Breed.Items.AddRange(petRepositories.GetAllBreedCats().ToArray());
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime monthYear = dtp_MonthYear.Value;
                int price = Convert.ToInt32(txt_Price.Text);
                int discount = Convert.ToInt32(txt_Discount.Text);

                Pets pet = new Pets(
                    txt_Id.Text.Trim(),
                    txt_Name.Text.Trim(),
                    dtp_MonthYear.Value,
                    cmb_Type.Text,
                    cmb_Breed.Text,
                    Convert.ToInt32(txt_Price.Text),
                    Convert.ToInt32(txt_Discount.Text)
                );

                petRepositories.CreatePet(pet);

                dtg_PetsList.DataSource = petRepositories.GetAllPets();
            }
            catch
            {
                MessageBox.Show("Cannot Create Pet");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime monthYear = dtp_MonthYear.Value;
                int price = Convert.ToInt32(txt_Price.Text);
                int discount = Convert.ToInt32(txt_Discount.Text);

                Pets pet = new Pets(
                    txt_Id.Text.Trim(),
                    txt_Name.Text.Trim(),
                    dtp_MonthYear.Value,
                    cmb_Type.Text,
                    cmb_Breed.Text,
                    Convert.ToInt32(txt_Price.Text),
                    Convert.ToInt32(txt_Discount.Text)
                );

                petRepositories.EditPet(pet);

                dtg_PetsList.DataSource = petRepositories.GetAllPets();
            }
            catch
            {
                MessageBox.Show("Cannot Edit Pet");
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                petRepositories.RemovePet(txt_Id.Text.Trim());

                dtg_PetsList.DataSource = petRepositories.GetAllPets();
            }
            catch
            {
                MessageBox.Show("Cannot Edit Pet");
            }
        }
    }
}
