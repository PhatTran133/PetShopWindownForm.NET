namespace PSMAPP
{
    partial class PetsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetsView));
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            dtg_PestsList = new DataGridView();
            groupBox2 = new GroupBox();
            label3 = new Label();
            txt_Search = new Button();
            txt_Name = new TextBox();
            btn_Back = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_PestsList).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleTurquoise;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtg_PestsList);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(86, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(729, 397);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("UD Digi Kyokasho NP-B", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(245, 19);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(255, 44);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Pet Shop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("UD Digi Kyokasho NP-B", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(278, 244);
            label2.Name = "label2";
            label2.Padding = new Padding(7);
            label2.Size = new Size(199, 38);
            label2.TabIndex = 2;
            label2.Text = "Pets are friends";
            // 
            // dtg_PestsList
            // 
            dtg_PestsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_PestsList.Location = new Point(21, 76);
            dtg_PestsList.Name = "dtg_PestsList";
            dtg_PestsList.RowTemplate.Height = 25;
            dtg_PestsList.Size = new Size(688, 153);
            dtg_PestsList.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Khaki;
            groupBox2.Controls.Add(btn_Back);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_Search);
            groupBox2.Controls.Add(txt_Name);
            groupBox2.Location = new Point(21, 292);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(688, 89);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Thistle;
            label3.Font = new Font("UD Digi Kyokasho NP-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(149, 22);
            label3.Name = "label3";
            label3.Padding = new Padding(11);
            label3.Size = new Size(82, 40);
            label3.TabIndex = 6;
            label3.Text = "Name:";
            // 
            // txt_Search
            // 
            txt_Search.BackColor = Color.PaleGreen;
            txt_Search.Font = new Font("UD Digi Kyokasho NP-B", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Search.Location = new Point(416, 22);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(75, 43);
            txt_Search.TabIndex = 5;
            txt_Search.Text = "Search";
            txt_Search.UseVisualStyleBackColor = false;
            txt_Search.Click += txt_Search_Click;
            // 
            // txt_Name
            // 
            txt_Name.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Name.Location = new Point(237, 21);
            txt_Name.Multiline = true;
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(173, 43);
            txt_Name.TabIndex = 4;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.LightSalmon;
            btn_Back.Font = new Font("UD Digi Kyokasho NP-B", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Back.Location = new Point(497, 22);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(75, 43);
            btn_Back.TabIndex = 7;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // PetsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(901, 494);
            Controls.Add(groupBox1);
            Name = "PetsView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PetsView";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_PestsList).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dtg_PestsList;
        private Label label1;
        private Label label2;
        private TextBox txt_Name;
        private Button txt_Search;
        private GroupBox groupBox2;
        private Label label3;
        private Button btn_Back;
    }
}