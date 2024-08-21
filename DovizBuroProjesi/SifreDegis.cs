using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovizBuroProjesi
{
    public partial class SifreDegis : Form
    {
        public SifreDegis()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string kullanıcıad;
        private void btndegis_Click(object sender, EventArgs e)
        {
            SqlCommand degis = new SqlCommand("UPDATE TBL_MUSTERI SET SIFRE=@P1 WHERE KULLANICIAD=@P2", bgl.baglanti());
            degis.Parameters.AddWithValue("@P1", txtyenisifre.Text);
            degis.Parameters.AddWithValue("@P2", lblkullanıcı.Text);
            degis.ExecuteNonQuery();
            MessageBox.Show("ŞİFRENİZ BAŞARILI BİR ŞEKİLDE DEĞİŞTİRİLMİŞTİR","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void SifreDegis_Load(object sender, EventArgs e)
        {
            lblkullanıcı.Text = kullanıcıad;
        }
    }
}
