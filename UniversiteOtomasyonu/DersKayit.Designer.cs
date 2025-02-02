namespace UniversiteOtomasyonu
{
    partial class DersKayit
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
            pnl_lessonRegister = new Panel();
            txt_lesson = new TextBox();
            label1 = new Label();
            cmb_lessonbolum = new ComboBox();
            label10 = new Label();
            cmb_lessonfakulte = new ComboBox();
            label11 = new Label();
            lst_lessons = new ListBox();
            btn_create = new Button();
            pnl_lessonRegister.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_lessonRegister
            // 
            pnl_lessonRegister.Controls.Add(btn_create);
            pnl_lessonRegister.Controls.Add(txt_lesson);
            pnl_lessonRegister.Controls.Add(label1);
            pnl_lessonRegister.Controls.Add(cmb_lessonbolum);
            pnl_lessonRegister.Controls.Add(label10);
            pnl_lessonRegister.Controls.Add(cmb_lessonfakulte);
            pnl_lessonRegister.Controls.Add(label11);
            pnl_lessonRegister.Controls.Add(lst_lessons);
            pnl_lessonRegister.Location = new Point(21, 35);
            pnl_lessonRegister.Name = "pnl_lessonRegister";
            pnl_lessonRegister.Size = new Size(745, 364);
            pnl_lessonRegister.TabIndex = 20;
            pnl_lessonRegister.Visible = false;
            // 
            // txt_lesson
            // 
            txt_lesson.Location = new Point(460, 26);
            txt_lesson.Name = "txt_lesson";
            txt_lesson.Size = new Size(238, 23);
            txt_lesson.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(389, 26);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 21;
            label1.Text = "Ders Adı";
            // 
            // cmb_lessonbolum
            // 
            cmb_lessonbolum.FormattingEnabled = true;
            cmb_lessonbolum.Location = new Point(110, 68);
            cmb_lessonbolum.Name = "cmb_lessonbolum";
            cmb_lessonbolum.Size = new Size(238, 23);
            cmb_lessonbolum.TabIndex = 20;
            cmb_lessonbolum.Click += cmb_lessonbolum_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 29);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 19;
            label10.Text = "Fakülte";
            // 
            // cmb_lessonfakulte
            // 
            cmb_lessonfakulte.FormattingEnabled = true;
            cmb_lessonfakulte.Location = new Point(110, 21);
            cmb_lessonfakulte.Name = "cmb_lessonfakulte";
            cmb_lessonfakulte.Size = new Size(238, 23);
            cmb_lessonfakulte.TabIndex = 18;
            cmb_lessonfakulte.SelectedIndexChanged += cmb_lessonfakulte_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 71);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 17;
            label11.Text = "Bölüm";
            // 
            // lst_lessons
            // 
            lst_lessons.FormattingEnabled = true;
            lst_lessons.ItemHeight = 15;
            lst_lessons.Location = new Point(39, 114);
            lst_lessons.Name = "lst_lessons";
            lst_lessons.Size = new Size(309, 229);
            lst_lessons.TabIndex = 1;
            // 
            // btn_create
            // 
            btn_create.Location = new Point(459, 82);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(239, 29);
            btn_create.TabIndex = 23;
            btn_create.Text = "Ders Kaydet";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // DersKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_lessonRegister);
            Name = "DersKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DersKayit";
            Load += DersKayit_Load;
            pnl_lessonRegister.ResumeLayout(false);
            pnl_lessonRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_lessonRegister;
        private ComboBox cmb_lessonbolum;
        private Label label10;
        private ComboBox cmb_lessonfakulte;
        private Label label11;
        private ListBox lst_lessons;
        private TextBox txt_lesson;
        private Label label1;
        private Button btn_create;
    }
}