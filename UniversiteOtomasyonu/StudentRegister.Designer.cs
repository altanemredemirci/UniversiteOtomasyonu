namespace UniversiteOtomasyonu
{
    partial class StudentRegister
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
            pnl_studentRegister = new Panel();
            btn_register = new Button();
            msk_phone = new MaskedTextBox();
            cmb_branch = new ComboBox();
            label9 = new Label();
            cmb_institute = new ComboBox();
            label8 = new Label();
            txt_pass = new TextBox();
            label7 = new Label();
            rd_woman = new RadioButton();
            rd_man = new RadioButton();
            label6 = new Label();
            txt_email = new TextBox();
            label5 = new Label();
            txt_tc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txt_surname = new TextBox();
            label2 = new Label();
            txt_name = new TextBox();
            label1 = new Label();
            pnl_studentRegister.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_studentRegister
            // 
            pnl_studentRegister.Controls.Add(btn_register);
            pnl_studentRegister.Controls.Add(msk_phone);
            pnl_studentRegister.Controls.Add(cmb_branch);
            pnl_studentRegister.Controls.Add(label9);
            pnl_studentRegister.Controls.Add(cmb_institute);
            pnl_studentRegister.Controls.Add(label8);
            pnl_studentRegister.Controls.Add(txt_pass);
            pnl_studentRegister.Controls.Add(label7);
            pnl_studentRegister.Controls.Add(rd_woman);
            pnl_studentRegister.Controls.Add(rd_man);
            pnl_studentRegister.Controls.Add(label6);
            pnl_studentRegister.Controls.Add(txt_email);
            pnl_studentRegister.Controls.Add(label5);
            pnl_studentRegister.Controls.Add(txt_tc);
            pnl_studentRegister.Controls.Add(label4);
            pnl_studentRegister.Controls.Add(label3);
            pnl_studentRegister.Controls.Add(txt_surname);
            pnl_studentRegister.Controls.Add(label2);
            pnl_studentRegister.Controls.Add(txt_name);
            pnl_studentRegister.Controls.Add(label1);
            pnl_studentRegister.Location = new Point(28, 43);
            pnl_studentRegister.Name = "pnl_studentRegister";
            pnl_studentRegister.Size = new Size(745, 364);
            pnl_studentRegister.TabIndex = 2;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(425, 181);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(238, 30);
            btn_register.TabIndex = 18;
            btn_register.Text = "Kaydet";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click_1;
            // 
            // msk_phone
            // 
            msk_phone.Location = new Point(89, 268);
            msk_phone.Mask = "(999) 000-0000";
            msk_phone.Name = "msk_phone";
            msk_phone.Size = new Size(212, 23);
            msk_phone.TabIndex = 17;
            // 
            // cmb_branch
            // 
            cmb_branch.FormattingEnabled = true;
            cmb_branch.Location = new Point(425, 118);
            cmb_branch.Name = "cmb_branch";
            cmb_branch.Size = new Size(238, 23);
            cmb_branch.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(354, 79);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 15;
            label9.Text = "Fakülte";
            // 
            // cmb_institute
            // 
            cmb_institute.FormattingEnabled = true;
            cmb_institute.Location = new Point(425, 71);
            cmb_institute.Name = "cmb_institute";
            cmb_institute.Size = new Size(238, 23);
            cmb_institute.TabIndex = 14;
            cmb_institute.SelectedIndexChanged += cmb_institute_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(354, 121);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 13;
            label8.Text = "Bölüm";
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(425, 26);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(238, 23);
            txt_pass.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(354, 29);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 11;
            label7.Text = "Şifre";
            // 
            // rd_woman
            // 
            rd_woman.AutoSize = true;
            rd_woman.Location = new Point(165, 166);
            rd_woman.Name = "rd_woman";
            rd_woman.Size = new Size(55, 19);
            rd_woman.TabIndex = 10;
            rd_woman.TabStop = true;
            rd_woman.Text = "Kadın";
            rd_woman.UseVisualStyleBackColor = true;
            // 
            // rd_man
            // 
            rd_man.AutoSize = true;
            rd_man.Location = new Point(89, 168);
            rd_man.Name = "rd_man";
            rd_man.Size = new Size(53, 19);
            rd_man.TabIndex = 9;
            rd_man.TabStop = true;
            rd_man.Text = "Erkek";
            rd_man.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 168);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 8;
            label6.Text = "Cinsiyet";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(87, 212);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(214, 23);
            txt_email.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 220);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 6;
            label5.Text = "Email";
            // 
            // txt_tc
            // 
            txt_tc.Location = new Point(87, 118);
            txt_tc.Name = "txt_tc";
            txt_tc.Size = new Size(214, 23);
            txt_tc.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 121);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 4;
            label4.Text = "TC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 271);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefon";
            // 
            // txt_surname
            // 
            txt_surname.Location = new Point(87, 71);
            txt_surname.Name = "txt_surname";
            txt_surname.Size = new Size(214, 23);
            txt_surname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 74);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Soyad";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(87, 26);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(214, 23);
            txt_name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // StudentRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_studentRegister);
            Name = "StudentRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentRegister";
            Load += StudentRegister_Load;
            pnl_studentRegister.ResumeLayout(false);
            pnl_studentRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_studentRegister;
        private Button btn_register;
        private MaskedTextBox msk_phone;
        private ComboBox cmb_branch;
        private Label label9;
        private ComboBox cmb_institute;
        private Label label8;
        private TextBox txt_pass;
        private Label label7;
        private RadioButton rd_woman;
        private RadioButton rd_man;
        private Label label6;
        private TextBox txt_email;
        private Label label5;
        private TextBox txt_tc;
        private Label label4;
        private Label label3;
        private TextBox txt_surname;
        private Label label2;
        private TextBox txt_name;
        private Label label1;
    }
}