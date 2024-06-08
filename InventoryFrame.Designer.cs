namespace DHVSU_Student_Information_System
{
    partial class InventoryFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryFrame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBTN = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            this.removeBTN = new System.Windows.Forms.Button();
            this.maritalStatusBox = new System.Windows.Forms.ComboBox();
            this.editBTN = new System.Windows.Forms.Button();
            this.provinceBox = new System.Windows.Forms.TextBox();
            this.barangayBox = new System.Windows.Forms.TextBox();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.municipalBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.streetNumberBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.middleInitialBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.csslogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csslogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.logoutBTN);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.csslogo);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 673);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoutBTN
            // 
            this.logoutBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutBTN.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.logoutBTN.FlatAppearance.BorderSize = 10;
            this.logoutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBTN.Location = new System.Drawing.Point(956, 627);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(105, 28);
            this.logoutBTN.TabIndex = 26;
            this.logoutBTN.Text = "Log out";
            this.logoutBTN.UseVisualStyleBackColor = false;
            this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ageBox);
            this.panel3.Controls.Add(this.removeBTN);
            this.panel3.Controls.Add(this.maritalStatusBox);
            this.panel3.Controls.Add(this.editBTN);
            this.panel3.Controls.Add(this.provinceBox);
            this.panel3.Controls.Add(this.barangayBox);
            this.panel3.Controls.Add(this.streetBox);
            this.panel3.Controls.Add(this.municipalBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.streetNumberBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.middleInitialBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.addBTN);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.firstNameBox);
            this.panel3.Controls.Add(this.lastNameBox);
            this.panel3.Controls.Add(this.lastName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(350, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(711, 362);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // ageBox
            // 
            this.ageBox.BackColor = System.Drawing.SystemColors.Window;
            this.ageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBox.InterceptArrowKeys = false;
            this.ageBox.Location = new System.Drawing.Point(88, 132);
            this.ageBox.Name = "ageBox";
            this.ageBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ageBox.Size = new System.Drawing.Size(109, 24);
            this.ageBox.TabIndex = 26;
            this.ageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // removeBTN
            // 
            this.removeBTN.BackColor = System.Drawing.Color.DarkSalmon;
            this.removeBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.removeBTN.FlatAppearance.BorderSize = 2;
            this.removeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBTN.Location = new System.Drawing.Point(462, 284);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(174, 55);
            this.removeBTN.TabIndex = 24;
            this.removeBTN.Text = "DELETE";
            this.removeBTN.UseVisualStyleBackColor = false;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // maritalStatusBox
            // 
            this.maritalStatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maritalStatusBox.FormattingEnabled = true;
            this.maritalStatusBox.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widow",
            "Separated"});
            this.maritalStatusBox.Location = new System.Drawing.Point(88, 210);
            this.maritalStatusBox.Name = "maritalStatusBox";
            this.maritalStatusBox.Size = new System.Drawing.Size(152, 28);
            this.maritalStatusBox.TabIndex = 25;
            // 
            // editBTN
            // 
            this.editBTN.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.editBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBTN.Location = new System.Drawing.Point(267, 284);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(174, 55);
            this.editBTN.TabIndex = 23;
            this.editBTN.Text = "UPDATE";
            this.editBTN.UseVisualStyleBackColor = false;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // provinceBox
            // 
            this.provinceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceBox.Location = new System.Drawing.Point(462, 232);
            this.provinceBox.Name = "provinceBox";
            this.provinceBox.Size = new System.Drawing.Size(189, 27);
            this.provinceBox.TabIndex = 22;
            this.provinceBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // barangayBox
            // 
            this.barangayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barangayBox.Location = new System.Drawing.Point(462, 166);
            this.barangayBox.Name = "barangayBox";
            this.barangayBox.Size = new System.Drawing.Size(189, 27);
            this.barangayBox.TabIndex = 20;
            // 
            // streetBox
            // 
            this.streetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetBox.Location = new System.Drawing.Point(462, 99);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(189, 27);
            this.streetBox.TabIndex = 13;
            // 
            // municipalBox
            // 
            this.municipalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.municipalBox.Location = new System.Drawing.Point(462, 199);
            this.municipalBox.Name = "municipalBox";
            this.municipalBox.Size = new System.Drawing.Size(189, 27);
            this.municipalBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(324, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Marital Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Province";
            // 
            // streetNumberBox
            // 
            this.streetNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetNumberBox.Location = new System.Drawing.Point(462, 132);
            this.streetNumberBox.Name = "streetNumberBox";
            this.streetNumberBox.Size = new System.Drawing.Size(189, 27);
            this.streetNumberBox.TabIndex = 16;
            this.streetNumberBox.TextChanged += new System.EventHandler(this.studentNumberBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(324, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Barangay";
            // 
            // middleInitialBox
            // 
            this.middleInitialBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleInitialBox.Location = new System.Drawing.Point(501, 50);
            this.middleInitialBox.Name = "middleInitialBox";
            this.middleInitialBox.Size = new System.Drawing.Size(142, 27);
            this.middleInitialBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(324, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Municipality";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(324, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Street Number";
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.Color.LightGreen;
            this.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addBTN.Location = new System.Drawing.Point(71, 284);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(174, 55);
            this.addBTN.TabIndex = 2;
            this.addBTN.Text = "ADD";
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(497, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Middle Initial";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(61, 50);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(201, 27);
            this.firstNameBox.TabIndex = 1;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(284, 50);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(198, 27);
            this.lastNameBox.TabIndex = 6;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(280, 23);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(99, 24);
            this.lastName.TabIndex = 4;
            this.lastName.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(74)))), ((int)(((byte)(104)))));
            this.panel2.Controls.Add(this.searchBTN);
            this.panel2.Controls.Add(this.searchBox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 50);
            this.panel2.TabIndex = 4;
            // 
            // searchBTN
            // 
            this.searchBTN.Location = new System.Drawing.Point(991, 17);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(78, 23);
            this.searchBTN.TabIndex = 25;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.searchBox.Location = new System.Drawing.Point(771, 17);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(219, 23);
            this.searchBox.TabIndex = 25;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(10, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(574, 32);
            this.label11.TabIndex = 25;
            this.label11.Text = "DHVSU STUDENT INVENTORY SYSTEM";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(24, 439);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1037, 173);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // csslogo
            // 
            this.csslogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.csslogo.Image = ((System.Drawing.Image)(resources.GetObject("csslogo.Image")));
            this.csslogo.Location = new System.Drawing.Point(-86, 40);
            this.csslogo.Name = "csslogo";
            this.csslogo.Size = new System.Drawing.Size(519, 389);
            this.csslogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.csslogo.TabIndex = 1;
            this.csslogo.TabStop = false;
            this.csslogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InventoryFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 664);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryFrame";
            this.Text = "InventoryFrame";
            this.Load += new System.EventHandler(this.InventoryFrame_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csslogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.PictureBox csslogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button removeBTN;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.Button logoutBTN;
        private System.Windows.Forms.NumericUpDown ageBox;
        private System.Windows.Forms.ComboBox maritalStatusBox;
        private System.Windows.Forms.TextBox provinceBox;
        private System.Windows.Forms.TextBox barangayBox;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.TextBox municipalBox;
        private System.Windows.Forms.TextBox streetNumberBox;
        private System.Windows.Forms.TextBox middleInitialBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
    }
}