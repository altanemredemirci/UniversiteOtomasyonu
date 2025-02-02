namespace UniversiteOtomasyonu
{
    partial class EmployeePanel
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
            menuStrip1 = new MenuStrip();
            öğrenciİşleriToolStripMenuItem = new ToolStripMenuItem();
            öğrenciKayıtToolStripMenuItem = new ToolStripMenuItem();
            dersKayıtToolStripMenuItem = new ToolStripMenuItem();
            öğrenciGüncelleToolStripMenuItem = new ToolStripMenuItem();
            öğrenciSilToolStripMenuItem = new ToolStripMenuItem();
            akademisyenİşleriToolStripMenuItem = new ToolStripMenuItem();
            akademisyenKayıtToolStripMenuItem = new ToolStripMenuItem();
            dersAtamaToolStripMenuItem = new ToolStripMenuItem();
            sınıfİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            sınıfToolStripMenuItem = new ToolStripMenuItem();
            sınıfGüncellemeToolStripMenuItem = new ToolStripMenuItem();
            sınıfSilmeToolStripMenuItem = new ToolStripMenuItem();
            dt_list = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt_list).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { öğrenciİşleriToolStripMenuItem, akademisyenİşleriToolStripMenuItem, sınıfİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciİşleriToolStripMenuItem
            // 
            öğrenciİşleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { öğrenciKayıtToolStripMenuItem, dersKayıtToolStripMenuItem, öğrenciGüncelleToolStripMenuItem, öğrenciSilToolStripMenuItem });
            öğrenciİşleriToolStripMenuItem.Name = "öğrenciİşleriToolStripMenuItem";
            öğrenciİşleriToolStripMenuItem.Size = new Size(108, 20);
            öğrenciİşleriToolStripMenuItem.Text = "Öğrenci İşlemleri";
            // 
            // öğrenciKayıtToolStripMenuItem
            // 
            öğrenciKayıtToolStripMenuItem.Name = "öğrenciKayıtToolStripMenuItem";
            öğrenciKayıtToolStripMenuItem.Size = new Size(180, 22);
            öğrenciKayıtToolStripMenuItem.Text = "Öğrenci Kayıt";
            öğrenciKayıtToolStripMenuItem.Click += öğrenciKayıtToolStripMenuItem_Click;
            // 
            // dersKayıtToolStripMenuItem
            // 
            dersKayıtToolStripMenuItem.Name = "dersKayıtToolStripMenuItem";
            dersKayıtToolStripMenuItem.Size = new Size(180, 22);
            dersKayıtToolStripMenuItem.Text = "Ders Kayıt";
            dersKayıtToolStripMenuItem.Click += dersKayıtToolStripMenuItem_Click;
            // 
            // öğrenciGüncelleToolStripMenuItem
            // 
            öğrenciGüncelleToolStripMenuItem.Name = "öğrenciGüncelleToolStripMenuItem";
            öğrenciGüncelleToolStripMenuItem.Size = new Size(180, 22);
            öğrenciGüncelleToolStripMenuItem.Text = "Öğrenci Güncelle";
            öğrenciGüncelleToolStripMenuItem.Click += öğrenciGüncelleToolStripMenuItem_Click;
            // 
            // öğrenciSilToolStripMenuItem
            // 
            öğrenciSilToolStripMenuItem.Name = "öğrenciSilToolStripMenuItem";
            öğrenciSilToolStripMenuItem.Size = new Size(180, 22);
            öğrenciSilToolStripMenuItem.Text = "Öğrenci Sil";
            öğrenciSilToolStripMenuItem.Click += öğrenciSilToolStripMenuItem_Click;
            // 
            // akademisyenİşleriToolStripMenuItem
            // 
            akademisyenİşleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { akademisyenKayıtToolStripMenuItem, dersAtamaToolStripMenuItem });
            akademisyenİşleriToolStripMenuItem.Name = "akademisyenİşleriToolStripMenuItem";
            akademisyenİşleriToolStripMenuItem.Size = new Size(137, 20);
            akademisyenİşleriToolStripMenuItem.Text = "Akademisyen İşlemleri";
            // 
            // akademisyenKayıtToolStripMenuItem
            // 
            akademisyenKayıtToolStripMenuItem.Name = "akademisyenKayıtToolStripMenuItem";
            akademisyenKayıtToolStripMenuItem.Size = new Size(180, 22);
            akademisyenKayıtToolStripMenuItem.Text = "Akademisyen Kayıt";
            akademisyenKayıtToolStripMenuItem.Click += akademisyenKayıtToolStripMenuItem_Click;
            // 
            // dersAtamaToolStripMenuItem
            // 
            dersAtamaToolStripMenuItem.Name = "dersAtamaToolStripMenuItem";
            dersAtamaToolStripMenuItem.Size = new Size(180, 22);
            dersAtamaToolStripMenuItem.Text = "Ders Atama";
            // 
            // sınıfİşlemleriToolStripMenuItem
            // 
            sınıfİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sınıfToolStripMenuItem, sınıfGüncellemeToolStripMenuItem, sınıfSilmeToolStripMenuItem });
            sınıfİşlemleriToolStripMenuItem.Name = "sınıfİşlemleriToolStripMenuItem";
            sınıfİşlemleriToolStripMenuItem.Size = new Size(89, 20);
            sınıfİşlemleriToolStripMenuItem.Text = "Sınıf İşlemleri";
            // 
            // sınıfToolStripMenuItem
            // 
            sınıfToolStripMenuItem.Name = "sınıfToolStripMenuItem";
            sınıfToolStripMenuItem.Size = new Size(146, 22);
            sınıfToolStripMenuItem.Text = "Sınıf Kayıt";
            // 
            // sınıfGüncellemeToolStripMenuItem
            // 
            sınıfGüncellemeToolStripMenuItem.Name = "sınıfGüncellemeToolStripMenuItem";
            sınıfGüncellemeToolStripMenuItem.Size = new Size(146, 22);
            sınıfGüncellemeToolStripMenuItem.Text = "Sınıf Güncelle";
            // 
            // sınıfSilmeToolStripMenuItem
            // 
            sınıfSilmeToolStripMenuItem.Name = "sınıfSilmeToolStripMenuItem";
            sınıfSilmeToolStripMenuItem.Size = new Size(146, 22);
            sınıfSilmeToolStripMenuItem.Text = "Sınıf Sil";
            // 
            // dt_list
            // 
            dt_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_list.Location = new Point(58, 101);
            dt_list.Name = "dt_list";
            dt_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dt_list.Size = new Size(671, 291);
            dt_list.TabIndex = 1;
            dt_list.MouseDoubleClick += dt_list_MouseDoubleClick;
            // 
            // EmployeePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dt_list);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "EmployeePanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeePanel";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dt_list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem öğrenciİşleriToolStripMenuItem;
        private ToolStripMenuItem öğrenciKayıtToolStripMenuItem;
        private ToolStripMenuItem dersKayıtToolStripMenuItem;
        private ToolStripMenuItem akademisyenİşleriToolStripMenuItem;
        private ToolStripMenuItem akademisyenKayıtToolStripMenuItem;
        private ToolStripMenuItem dersAtamaToolStripMenuItem;
        private ToolStripMenuItem sınıfİşlemleriToolStripMenuItem;
        private ToolStripMenuItem sınıfToolStripMenuItem;
        private ToolStripMenuItem öğrenciGüncelleToolStripMenuItem;
        private ToolStripMenuItem öğrenciSilToolStripMenuItem;
        private ToolStripMenuItem sınıfGüncellemeToolStripMenuItem;
        private ToolStripMenuItem sınıfSilmeToolStripMenuItem;
        private TextBox txt_phone;
        private DataGridView dt_list;
    }
}