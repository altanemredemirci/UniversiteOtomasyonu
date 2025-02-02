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
    public partial class StudentUpdate : Form
    {
        DataContext db = new DataContext();
        Ogrenci updateOgrenci;


        public StudentUpdate(int Id)
        {
            InitializeComponent();
            updateOgrenci = db.Ogrencis.Find(Id); // Find(key) ile çalışır. Key => tablonun Primary Key

            txt_email.Text = updateOgrenci.Email;
            txt_name.Text = updateOgrenci.Ad;
            txt_surname.Text = updateOgrenci.Soyad;
            txt_pass.Text = updateOgrenci.Password;
            txt_tc.Text = updateOgrenci.TC;
            txt_tc.Enabled = false;
            rd_man.Checked = updateOgrenci.Cinsiyet == "Erkek" ? true : rd_woman.Checked = true;
            msk_phone.Text = updateOgrenci.Telefon;
            ComboBoxLoader();

            int fakulteId = db.Bolums.Where(i => i.Id == updateOgrenci.BolumId).Select(i => i.FakulteId).FirstOrDefault();


            cmb_institute.SelectedValue = fakulteId;

            cmb_branch.DataSource = db.Bolums.Where(i => i.FakulteId == fakulteId).ToList();
            cmb_branch.DisplayMember = "Ad";
            cmb_branch.ValueMember = "Id";
            cmb_branch.SelectedValue = updateOgrenci.BolumId;
        }

        private void ComboBoxLoader()
        {
            cmb_institute.DataSource = db.Fakultes.ToList();
            cmb_institute.DisplayMember = "Ad";
            cmb_institute.ValueMember = "Id";
            cmb_institute.SelectedIndex = -1;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            updateOgrenci.Cinsiyet = rd_woman.Checked == true ? "Kadın" : "Erkek";
            updateOgrenci.Email = txt_email.Text;
            updateOgrenci.Ad = txt_name.Text;
            updateOgrenci.Soyad = txt_surname.Text;
            updateOgrenci.BolumId = (int)cmb_branch.SelectedValue;
            updateOgrenci.Password = txt_pass.Text;
            updateOgrenci.Telefon = msk_phone.Text;

            db.SaveChanges();
        }
    }
}

