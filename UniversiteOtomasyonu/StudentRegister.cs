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
    public partial class StudentRegister : Form
    {
        DataContext db = new DataContext();
        public StudentRegister()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

        }

        private void StudentRegister_Load(object sender, EventArgs e)
        {
            pnl_studentRegister.Visible = true;
            cmb_institute.DataSource = db.Fakultes.ToList();
            cmb_institute.DisplayMember = "Ad";
            cmb_institute.ValueMember = "Id";
            cmb_institute.SelectedIndex = -1;
        }

        private void cmb_institute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_institute.SelectedItem != null)
            {
                int fakulteId = ((Fakulte)cmb_institute.SelectedItem).Id;

                cmb_branch.DataSource = db.Bolums.Where(i => i.FakulteId == fakulteId).ToList();
                cmb_branch.DisplayMember = "Ad";
                cmb_branch.ValueMember = "Id";
                cmb_branch.SelectedIndex = -1;
            }

        }

        private void btn_register_Click_1(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.TC = txt_tc.Text;
            ogrenci.Cinsiyet = rd_man.Checked == true ? rd_man.Text : rd_woman.Text;
            ogrenci.Email = txt_email.Text;
            ogrenci.Ad = txt_name.Text;
            ogrenci.Soyad = txt_surname.Text;
            ogrenci.Password = txt_pass.Text;
            ogrenci.Telefon = msk_phone.Text;
            ogrenci.BolumId = (int)cmb_branch.SelectedValue;

            db.Ogrencis.Add(ogrenci);
            db.SaveChanges();

            txt_email.Text = "";
            txt_name.Text = "";
            txt_pass.Text = "";
            msk_phone.Text = "";
            txt_surname.Text = "";
            txt_tc.Text = "";
            cmb_branch.SelectedIndex = -1;
            cmb_institute.SelectedIndex = -1;

            MessageBox.Show("Kayıt Başarılı!");

            this.Hide();
        }       
    }
}
