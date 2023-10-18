namespace PSMAPP
{
    partial class AccountsManagement
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            dtg_AccountsList = new DataGridView();
            groupBox2 = new GroupBox();
            cmb_Role = new ComboBox();
            txt_Password = new TextBox();
            txt_Username = new TextBox();
            txt_Id = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btn_Back = new Button();
            btn_Remove = new Button();
            btn_Edit = new Button();
            btn_Create = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_AccountsList).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Honeydew;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtg_AccountsList);
            groupBox1.Location = new Point(28, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(842, 203);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Accounts1;
            pictureBox1.Location = new Point(77, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 145);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.PaleGreen;
            label5.Font = new Font("UD Digi Kyokasho NP-B", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(352, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(5);
            label5.Size = new Size(174, 38);
            label5.TabIndex = 1;
            label5.Text = "Account List";
            // 
            // dtg_AccountsList
            // 
            dtg_AccountsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_AccountsList.Location = new Point(288, 51);
            dtg_AccountsList.Name = "dtg_AccountsList";
            dtg_AccountsList.RowTemplate.Height = 25;
            dtg_AccountsList.Size = new Size(440, 135);
            dtg_AccountsList.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Honeydew;
            groupBox2.Controls.Add(cmb_Role);
            groupBox2.Controls.Add(txt_Password);
            groupBox2.Controls.Add(txt_Username);
            groupBox2.Controls.Add(txt_Id);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(28, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(580, 230);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // cmb_Role
            // 
            cmb_Role.FormattingEnabled = true;
            cmb_Role.Location = new Point(278, 186);
            cmb_Role.Name = "cmb_Role";
            cmb_Role.Size = new Size(168, 23);
            cmb_Role.TabIndex = 7;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(278, 134);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(168, 23);
            txt_Password.TabIndex = 6;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(278, 83);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(168, 23);
            txt_Username.TabIndex = 5;
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(278, 31);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(168, 23);
            txt_Id.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UD Digi Kyokasho NP-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(148, 187);
            label4.Name = "label4";
            label4.Size = new Size(59, 22);
            label4.TabIndex = 3;
            label4.Text = "Role:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho NP-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(98, 135);
            label3.Name = "label3";
            label3.Size = new Size(109, 22);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NP-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(93, 84);
            label2.Name = "label2";
            label2.Size = new Size(114, 22);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(166, 32);
            label1.Name = "label1";
            label1.Size = new Size(41, 22);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Honeydew;
            groupBox3.Controls.Add(btn_Back);
            groupBox3.Controls.Add(btn_Remove);
            groupBox3.Controls.Add(btn_Edit);
            groupBox3.Controls.Add(btn_Create);
            groupBox3.Location = new Point(632, 247);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(238, 230);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.SandyBrown;
            btn_Back.Location = new Point(86, 174);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(75, 45);
            btn_Back.TabIndex = 3;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.BackColor = Color.Salmon;
            btn_Remove.Location = new Point(86, 122);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(75, 45);
            btn_Remove.TabIndex = 2;
            btn_Remove.Text = "Remove";
            btn_Remove.UseVisualStyleBackColor = false;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.LightBlue;
            btn_Edit.Location = new Point(86, 71);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(75, 45);
            btn_Edit.TabIndex = 1;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Create
            // 
            btn_Create.BackColor = Color.PaleGreen;
            btn_Create.Location = new Point(86, 18);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(75, 46);
            btn_Create.TabIndex = 0;
            btn_Create.Text = "Create";
            btn_Create.UseVisualStyleBackColor = false;
            btn_Create.Click += btn_Create_Click;
            // 
            // AccountsManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(901, 494);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AccountsManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountManagement";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_AccountsList).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dtg_AccountsList;
        private TextBox txt_Username;
        private TextBox txt_Id;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmb_Role;
        private TextBox txt_Password;
        private Button btn_Back;
        private Button btn_Remove;
        private Button btn_Edit;
        private Button btn_Create;
        private Label label5;
        private PictureBox pictureBox1;
    }
}