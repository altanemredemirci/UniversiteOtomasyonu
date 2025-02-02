using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversiteOtomasyonu.Context;
using UniversiteOtomasyonu.Entities;

namespace UniversiteOtomasyonu
{
    public partial class EmployeePanel : Form
    {
        DataContext db = new DataContext();

        public EmployeePanel()
        {
            InitializeComponent();

        }

        private void öğrenciKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentRegister form = new StudentRegister();
            form.Show();
        }





        private void dersKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersKayit form = new DersKayit();
            form.Show();
        }

        private void cmb_lessonfakulte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void öğrenciGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt_list.DataSource = db.Ogrencis.ToList();
        }

        private void dt_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int ogrenciId = (int)((DataGridView)sender).SelectedRows[0].Cells[0].Value;

            if (ogrenciId > 0)
            {
                DialogResult result = MessageBox.Show("Güncelleme YES - Silme NO", "İşlem", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    StudentUpdate form = new StudentUpdate(ogrenciId);
                    form.Show();
                }
                else if (result == DialogResult.No)
                {
                    DialogResult resultDelete = MessageBox.Show("Silme İstediğinize Emin Misiniz?", "Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (resultDelete == DialogResult.OK)
                    {
                        var ogrenci = db.Ogrencis.Find(ogrenciId);
                        db.Ogrencis.Remove(ogrenci);
                        db.SaveChanges();
                        dt_list.DataSource = db.Ogrencis.ToList();

                    }
                }

            }
        }

        private void öğrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt_list.DataSource = db.Ogrencis.ToList();
        }

        private void akademisyenKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AkademisyenKayit form = new AkademisyenKayit();
            form.Show();
        }
    }
}
