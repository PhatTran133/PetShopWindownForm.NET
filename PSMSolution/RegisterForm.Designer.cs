namespace PSMAPP
{
    partial class RegisterForm
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
            txt_Password = new TextBox();
            txt_Username = new TextBox();
            btn_Back = new Button();
            btn_Register = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MintCream;
            groupBox1.Controls.Add(txt_Password);
            groupBox1.Controls.Add(txt_Username);
            groupBox1.Controls.Add(btn_Back);
            groupBox1.Controls.Add(btn_Register);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("UD Digi Kyokasho NP-B", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(212, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 276);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txt_Password
            // 
            txt_Password.BackColor = SystemColors.Window;
            txt_Password.Font = new Font("UD Digi Kyokasho NP-B", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Password.ForeColor = SystemColors.WindowText;
            txt_Password.Location = new Point(186, 140);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(176, 21);
            txt_Password.TabIndex = 7;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Username
            // 
            txt_Username.BackColor = SystemColors.Window;
            txt_Username.Font = new Font("UD Digi Kyokasho NP-B", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Username.ForeColor = SystemColors.WindowText;
            txt_Username.Location = new Point(186, 79);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(176, 21);
            txt_Username.TabIndex = 6;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.SandyBrown;
            btn_Back.Font = new Font("UD Digi Kyokasho NP-B", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Back.ForeColor = SystemColors.ControlText;
            btn_Back.Location = new Point(283, 214);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(94, 43);
            btn_Back.TabIndex = 5;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.SkyBlue;
            btn_Register.Font = new Font("UD Digi Kyokasho NP-B", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Register.Location = new Point(110, 214);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(94, 43);
            btn_Register.TabIndex = 3;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btn_Register_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(75, 143);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 79);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-B", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(195, 17);
            label1.Name = "label1";
            label1.Size = new Size(99, 24);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tải_xuống;
            ClientSize = new Size(901, 494);
            Controls.Add(groupBox1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_Password;
        private TextBox txt_Username;
        private Button btn_Back;
        private Button btn_Register;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}