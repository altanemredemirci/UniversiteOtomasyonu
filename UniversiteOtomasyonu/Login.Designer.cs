namespace UniversiteOtomasyonu
{
    partial class Login
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
            txt_password = new TextBox();
            label2 = new Label();
            txt_tc = new TextBox();
            label1 = new Label();
            btn_login = new Button();
            lbl_yetki = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_yetki);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_tc);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_login);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 223);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "GİRİŞ PANELİ";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 11F);
            txt_password.Location = new Point(87, 116);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(224, 27);
            txt_password.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(25, 119);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "ŞİFRE:";
            // 
            // txt_tc
            // 
            txt_tc.Font = new Font("Segoe UI", 11F);
            txt_tc.Location = new Point(87, 58);
            txt_tc.Name = "txt_tc";
            txt_tc.Size = new Size(224, 27);
            txt_tc.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(25, 61);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 1;
            label1.Text = "TC:";
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 11F);
            btn_login.Location = new Point(217, 172);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 32);
            btn_login.TabIndex = 0;
            btn_login.Text = "GİRİŞ";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // lbl_yetki
            // 
            lbl_yetki.AutoSize = true;
            lbl_yetki.Location = new Point(37, 166);
            lbl_yetki.Name = "lbl_yetki";
            lbl_yetki.Size = new Size(0, 25);
            lbl_yetki.TabIndex = 5;
            lbl_yetki.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 249);
            Controls.Add(groupBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_password;
        private Label label2;
        private TextBox txt_tc;
        private Label label1;
        private Button btn_login;
        private Label lbl_yetki;
    }
}