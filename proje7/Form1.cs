using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double kilo, boy, vucut_kitle_indeksi;
            kilo=Convert.ToDouble(txtKilo.Text);
            boy=Convert.ToDouble(txtBoy.Text);
            vucut_kitle_indeksi=kilo/(boy*boy);
            
           
            if(vucut_kitle_indeksi<18)
            {
                MessageBox.Show("ideal kilonun altı ");
            }
            else if (vucut_kitle_indeksi > 18.5 && vucut_kitle_indeksi < 24.99)
            {
                MessageBox.Show("ideal kilo");
            }
            else if (vucut_kitle_indeksi > 25 && vucut_kitle_indeksi < 29.99)
            {
                MessageBox.Show("ideal kilonun üzeri");
            }
            else if (vucut_kitle_indeksi > 30)
            {
                MessageBox.Show("ideal kilonun çok üzeri");
            }
            else
            {
                MessageBox.Show("değerlerinizi giriniz");
            }
        }
    }
}
