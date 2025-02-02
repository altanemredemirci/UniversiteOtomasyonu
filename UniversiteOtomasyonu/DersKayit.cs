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
    public partial class DersKayit : Form
    {
        DataContext db = new DataContext();

        public DersKayit()
        {
            InitializeComponent();
        }

        private void cmb_lessonfakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_lessonfakulte.SelectedItem != null)
            {
                int fakulteId = ((Fakulte)cmb_lessonfakulte.SelectedItem).Id;

                cmb_lessonbolum.DataSource = db.Bolums.Where(i => i.FakulteId == fakulteId).ToList();
                cmb_lessonbolum.DisplayMember = "Ad";
                cmb_lessonbolum.ValueMember = "Id";
                cmb_lessonbolum.SelectedIndex = -1;
            }
        }

        private void DersKayit_Load(object sender, EventArgs e)
        {
            pnl_lessonRegister.Visible = true;
            cmb_lessonfakulte.DataSource = db.Fakultes.ToList();
            cmb_lessonfakulte.DisplayMember = "Ad";
            cmb_lessonfakulte.ValueMember = "Id";
            cmb_lessonfakulte.SelectedIndex = -1;

        }

        private void cmb_lessonbolum_Click(object sender, EventArgs e)
        {
            if (cmb_lessonbolum.SelectedItem != null)
            {
                lst_lessons.Items.Clear();

                int bolumId = ((Bolum)cmb_lessonbolum.SelectedItem).Id;
                var dersler = db.BolumDers.Where(i => i.BolumId == bolumId).Select(i => i.Ders).ToList();

                foreach (var item in dersler)
                {
                    lst_lessons.Items.Add(item);
                }

            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Ders ders = new Ders()
            {
                Ad = txt_lesson.Text
            };


            db.Derss.Add(ders);
            db.SaveChanges();

            BolumDers bolumDers = new BolumDers();

            bolumDers.BolumId = (int)cmb_lessonbolum.SelectedValue;
            bolumDers.DersId = ders.Id;


            db.BolumDers.Add(bolumDers);

            db.SaveChanges();
        }
    }
}
