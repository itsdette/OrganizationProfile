namespace OrganizationProfile
{
    partial class frmRegistration
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
            label1 = new Label();
            label2 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label4 = new Label();
            txtMiddleInitial = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cbPrograms = new ComboBox();
            txtAge = new TextBox();
            label7 = new Label();
            cbGender = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            datePickerBirthday = new DateTimePicker();
            txtContactNo = new TextBox();
            label10 = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(478, 19);
            label1.Name = "label1";
            label1.Size = new Size(259, 43);
            label1.TabIndex = 0;
            label1.Text = "REGISTRATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 97);
            label2.Name = "label2";
            label2.Size = new Size(180, 33);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentNo.Location = new Point(195, 91);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(300, 39);
            txtStudentNo.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(195, 171);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(300, 39);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 177);
            label3.Name = "label3";
            label3.Size = new Size(150, 33);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(677, 171);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(300, 39);
            txtFirstName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(507, 174);
            label4.Name = "label4";
            label4.Size = new Size(165, 33);
            label4.TabIndex = 5;
            label4.Text = "First Name";
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMiddleInitial.Location = new Point(1080, 171);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(85, 39);
            txtMiddleInitial.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(999, 174);
            label5.Name = "label5";
            label5.Size = new Size(75, 33);
            label5.TabIndex = 7;
            label5.Text = "M.I.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(552, 97);
            label6.Name = "label6";
            label6.Size = new Size(120, 33);
            label6.TabIndex = 9;
            label6.Text = "Program";
            // 
            // cbPrograms
            // 
            cbPrograms.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(677, 94);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(488, 40);
            cbPrograms.TabIndex = 10;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(195, 252);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(249, 39);
            txtAge.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(129, 258);
            label7.Name = "label7";
            label7.Size = new Size(60, 33);
            label7.TabIndex = 11;
            label7.Text = "Age";
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male" });
            cbGender.Location = new Point(677, 249);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(260, 40);
            cbGender.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(566, 255);
            label8.Name = "label8";
            label8.Size = new Size(105, 33);
            label8.TabIndex = 13;
            label8.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(54, 337);
            label9.Name = "label9";
            label9.Size = new Size(135, 33);
            label9.TabIndex = 15;
            label9.Text = "Birthday";
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.CalendarFont = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            datePickerBirthday.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            datePickerBirthday.Location = new Point(195, 335);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(445, 34);
            datePickerBirthday.TabIndex = 16;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtContactNo.Location = new Point(846, 333);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(300, 39);
            txtContactNo.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(660, 336);
            label10.Name = "label10";
            label10.Size = new Size(180, 33);
            label10.TabIndex = 17;
            label10.Text = "Contact No.";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightPink;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(505, 417);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(204, 55);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1181, 498);
            Controls.Add(btnRegister);
            Controls.Add(txtContactNo);
            Controls.Add(label10);
            Controls.Add(datePickerBirthday);
            Controls.Add(label9);
            Controls.Add(cbGender);
            Controls.Add(label8);
            Controls.Add(txtAge);
            Controls.Add(label7);
            Controls.Add(cbPrograms);
            Controls.Add(label6);
            Controls.Add(txtMiddleInitial);
            Controls.Add(label5);
            Controls.Add(txtFirstName);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtStudentNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegistration";
            Text = "Organization Profile";
            Load += frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private Label label4;
        private TextBox txtMiddleInitial;
        private Label label5;
        private Label label6;
        private ComboBox cbPrograms;
        private TextBox txtAge;
        private Label label7;
        private ComboBox cbGender;
        private Label label8;
        private Label label9;
        private DateTimePicker datePickerBirthday;
        private TextBox txtContactNo;
        private Label label10;
        private Button btnRegister;
    }
}