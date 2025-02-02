namespace UniversiteOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_loginStdnt = new Button();
            btn_loginTeachr = new Button();
            label1 = new Label();
            btn_loginEmployee = new Button();
            SuspendLayout();
            // 
            // btn_loginStdnt
            // 
            btn_loginStdnt.Location = new Point(124, 169);
            btn_loginStdnt.Name = "btn_loginStdnt";
            btn_loginStdnt.Size = new Size(201, 44);
            btn_loginStdnt.TabIndex = 0;
            btn_loginStdnt.Text = "ÖĞRENCİ GİRİŞ";
            btn_loginStdnt.UseVisualStyleBackColor = true;
            btn_loginStdnt.Click += btn_loginStdnt_Click;
            // 
            // btn_loginTeachr
            // 
            btn_loginTeachr.Location = new Point(449, 169);
            btn_loginTeachr.Name = "btn_loginTeachr";
            btn_loginTeachr.Size = new Size(193, 44);
            btn_loginTeachr.TabIndex = 1;
            btn_loginTeachr.Text = "AKADEMİSYEN GİRİŞ";
            btn_loginTeachr.UseVisualStyleBackColor = true;
            btn_loginTeachr.Click += btn_loginTeachr_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(255, 77);
            label1.Name = "label1";
            label1.Size = new Size(292, 40);
            label1.TabIndex = 2;
            label1.Text = "ALTAN ÜNİVERSİTESİ";
            // 
            // btn_loginEmployee
            // 
            btn_loginEmployee.Location = new Point(287, 264);
            btn_loginEmployee.Name = "btn_loginEmployee";
            btn_loginEmployee.Size = new Size(193, 44);
            btn_loginEmployee.TabIndex = 3;
            btn_loginEmployee.Text = "PERSONEL GİRİŞ";
            btn_loginEmployee.UseVisualStyleBackColor = true;
            btn_loginEmployee.Click += btn_loginEmployee_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_loginEmployee);
            Controls.Add(label1);
            Controls.Add(btn_loginTeachr);
            Controls.Add(btn_loginStdnt);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_loginStdnt;
        private Button btn_loginTeachr;
        private Label label1;
        private Button btn_loginEmployee;
    }
}
