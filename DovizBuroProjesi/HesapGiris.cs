using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DovizBuroProjesi
{
    public partial class HesapGiris : Form
    {
        public HesapGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand giris = new SqlCommand("SELECT * FROM TBL_MUSTERI WHERE KULLANICIAD=@P1 AND SIFRE=@P2",bgl.baglanti());
            giris.Parameters.AddWithValue("@P1", txtkullaniciad.Text);
            giris.Parameters.AddWithValue("@P2", txtsifre.Text);
            SqlDataReader OKU = giris.ExecuteReader();
            if(OKU.Read())
            {
                txtkullaniciad.Text = OKU[3].ToString();
                txtsifre.Text = OKU[4].ToString();
                DovizSayfasi git = new DovizSayfasi();
                git.kullanıcıad = txtkullaniciad.Text;
                git.Show();
            }
            else
            {
                MessageBox.Show("KULLANCI ADI VEYA ŞİFRE HATALI LÜTFEN TEKRAR DENEYİNİZ","GİRİŞ HATASI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void HesapGiris_Load(object sender, EventArgs e)
        {
            txtkullaniciad.Text = "Melih";
            txtsifre.Text = "m34";
        }
    }
}
