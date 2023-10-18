namespace PSMAPP
{
    partial class PetsManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox3 = new GroupBox();
            btn_Back = new Button();
            btn_Edit = new Button();
            btn_Remove = new Button();
            btn_Create = new Button();
            groupBox2 = new GroupBox();
            label8 = new Label();
            txt_Name = new TextBox();
            txt_Discount = new TextBox();
            cmb_Breed = new ComboBox();
            label7 = new Label();
            txt_Price = new TextBox();
            cmb_Type = new ComboBox();
            dtp_MonthYear = new DateTimePicker();
            txt_Id = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            dtg_PetsList = new DataGridView();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_PetsList).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Honeydew;
            groupBox3.Controls.Add(btn_Back);
            groupBox3.Controls.Add(btn_Edit);
            groupBox3.Controls.Add(btn_Remove);
            groupBox3.Controls.Add(btn_Create);
            groupBox3.Location = new Point(653, 239);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(219, 234);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.SandyBrown;
            btn_Back.Location = new Point(77, 173);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(75, 45);
            btn_Back.TabIndex = 9;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.LightBlue;
            btn_Edit.Location = new Point(77, 70);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(75, 45);
            btn_Edit.TabIndex = 7;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.BackColor = Color.Salmon;
            btn_Remove.Location = new Point(77, 121);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(75, 45);
            btn_Remove.TabIndex = 8;
            btn_Remove.Text = "Remove";
            btn_Remove.UseVisualStyleBackColor = false;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // btn_Create
            // 
            btn_Create.BackColor = Color.PaleGreen;
            btn_Create.Location = new Point(77, 17);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(75, 46);
            btn_Create.TabIndex = 6;
            btn_Create.Text = "Create";
            btn_Create.UseVisualStyleBackColor = false;
            btn_Create.Click += btn_Create_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Honeydew;
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txt_Name);
            groupBox2.Controls.Add(txt_Discount);
            groupBox2.Controls.Add(cmb_Breed);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txt_Price);
            groupBox2.Controls.Add(cmb_Type);
            groupBox2.Controls.Add(dtp_MonthYear);
            groupBox2.Controls.Add(txt_Id);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(24, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(601, 234);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(62, 132);
            label8.Name = "label8";
            label8.Size = new Size(58, 17);
            label8.TabIndex = 14;
            label8.Text = "Name:";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(140, 130);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(190, 23);
            txt_Name.TabIndex = 13;
            // 
            // txt_Discount
            // 
            txt_Discount.Location = new Point(479, 185);
            txt_Discount.Name = "txt_Discount";
            txt_Discount.Size = new Size(78, 23);
            txt_Discount.TabIndex = 12;
            // 
            // cmb_Breed
            // 
            cmb_Breed.FormattingEnabled = true;
            cmb_Breed.Location = new Point(479, 82);
            cmb_Breed.Name = "cmb_Breed";
            cmb_Breed.Size = new Size(78, 23);
            cmb_Breed.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(394, 82);
            label7.Name = "label7";
            label7.Size = new Size(60, 17);
            label7.TabIndex = 10;
            label7.Text = "Breed:";
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(479, 133);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(78, 23);
            txt_Price.TabIndex = 8;
            // 
            // cmb_Type
            // 
            cmb_Type.FormattingEnabled = true;
            cmb_Type.Location = new Point(479, 33);
            cmb_Type.Name = "cmb_Type";
            cmb_Type.Size = new Size(78, 23);
            cmb_Type.TabIndex = 7;
            cmb_Type.SelectedIndexChanged += cmb_Type_SelectedIndexChanged;
            // 
            // dtp_MonthYear
            // 
            dtp_MonthYear.Location = new Point(140, 82);
            dtp_MonthYear.Name = "dtp_MonthYear";
            dtp_MonthYear.Size = new Size(190, 23);
            dtp_MonthYear.TabIndex = 6;
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(140, 33);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(190, 23);
            txt_Id.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(373, 191);
            label6.Name = "label6";
            label6.Size = new Size(83, 17);
            label6.TabIndex = 4;
            label6.Text = "Discount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(402, 136);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 3;
            label4.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(402, 33);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 2;
            label3.Text = "Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(108, 17);
            label2.TabIndex = 1;
            label2.Text = "Month/Year:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(87, 33);
            label1.Name = "label1";
            label1.Size = new Size(33, 17);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Honeydew;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtg_PetsList);
            groupBox1.Location = new Point(24, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(848, 198);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Khaki;
            label5.Font = new Font("UD Digi Kyokasho NP-B", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(373, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(5);
            label5.Size = new Size(131, 38);
            label5.TabIndex = 2;
            label5.Text = "Pets List";
            // 
            // dtg_PetsList
            // 
            dtg_PetsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_PetsList.Location = new Point(6, 41);
            dtg_PetsList.Name = "dtg_PetsList";
            dtg_PetsList.RowTemplate.Height = 25;
            dtg_PetsList.Size = new Size(833, 151);
            dtg_PetsList.TabIndex = 0;
            // 
            // PetsManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(901, 494);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PetsManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PetsManagement";
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_PetsList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dtg_PetsList;
        private TextBox txt_Price;
        private ComboBox cmb_Type;
        private DateTimePicker dtp_MonthYear;
        private TextBox txt_Id;
        private Label label6;
        private Label label7;
        private ComboBox cmb_Breed;
        private Button btn_Back;
        private Button btn_Edit;
        private Button btn_Remove;
        private Button btn_Create;
        private Label label5;
        private TextBox txt_Discount;
        private Label label8;
        private TextBox txt_Name;
    }
}