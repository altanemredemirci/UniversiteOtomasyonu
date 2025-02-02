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

namespace UniversiteOtomasyonu
{
    public partial class Login : Form
    {
        public Login(int yetkiId)
        {
            InitializeComponent();
            lbl_yetki.Text = yetkiId.ToString();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext();

            var kullanici = db.Kullanicis.FirstOrDefault(i => i.TC == txt_tc.Text && i.Password == txt_password.Text && i.Yetki == Convert.ToInt32(lbl_yetki.Text));

            if (kullanici != null)
            {
                if (kullanici.Yetki == 0)
                {
                    StudentPanel studentPanel = new StudentPanel();
                    studentPanel.Show();
                    this.Hide();
                }
                else if (kullanici.Yetki == 1)
                {

                }

                else if (kullanici.Yetki == 2)
                {
                    EmployeePanel employeePanel = new EmployeePanel();
                    employeePanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş yetkiniz yoktur.!!");
                }
            }
            else
            {
                MessageBox.Show("Giriş Bilgilerinizi Kontrol Ediniz!!");
            }
        }
    }
}
