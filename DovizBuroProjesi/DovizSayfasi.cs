using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;

namespace DovizBuroProjesi
{
    public partial class DovizSayfasi : Form
    {
        public DovizSayfasi()
        {
            InitializeComponent();
        }
        public string kullanıcıad;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void DovizSayfasi_Load(object sender, EventArgs e)
        {
            lblkullanıcı.Text = kullanıcıad;
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lbldolaralis.Text = dolaralis;
            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lbldolarsatis.Text = dolarsatis;
            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbleuroalis.Text = euroalis;
            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbleurosatis.Text = eurosatis;
            string sterlinalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            lblsterlinalis.Text = sterlinalis;
            string sterlinsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            lblsterlinsatis.Text = sterlinsatis;
        }

        private void cmbalis_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbalis.SelectedItem.ToString() == "DOLAR")
            {
                txtkur.Text = lbldolaralis.Text.Replace(".", ",");
            }
            if (cmbalis.SelectedItem.ToString() == "EURO")
            {
                txtkur.Text = lbleuroalis.Text.Replace(".", ",");

            }
            if (cmbalis.SelectedItem.ToString() == "STERLİN")
            {
                txtkur.Text = lblsterlinalis.Text.Replace(".", ",");
            }
        }

        private void btnsatisyap_Click(object sender, EventArgs e)
        {
            try
            {
                double kur, miktar, tutar;
                kur = Convert.ToDouble(txtkur.Text);
                miktar = Convert.ToDouble(txtmiktar.Text);
                tutar = miktar * kur;
                txttutar.Text = tutar.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("LÜTFEN GEÇERLİ BİR DEĞER GİRİN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbsatis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsatis.SelectedItem.ToString() == "DOLAR")
            {
                txtkursatis.Text = lbldolarsatis.Text.Replace(".", ",");
            }
            if (cmbsatis.SelectedItem.ToString() == "EURO")
            {
                txtkursatis.Text = lbleurosatis.Text.Replace(".", ",");

            }
            if (cmbsatis.SelectedItem.ToString() == "STERLİN")
            {
                txtkursatis.Text = lblsterlinsatis.Text.Replace(".", ",");
            }
        }
        private void btnsatis_Click(object sender, EventArgs e)
        {
            try
            {
                double kur, miktar, tutar;
                kur = Convert.ToDouble(txtkursatis.Text);
                miktar = Convert.ToDouble(txtadetsatis.Text);
                tutar = miktar * kur;
                txttutarsatis.Text = tutar.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("LÜTFEN GEÇERLİ BİR DEĞER GİRİN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsifredegis_Click(object sender, EventArgs e)
        {
            SifreDegis git = new SifreDegis();
            git.kullanıcıad = lblkullanıcı.Text;
            git.Show();
        }
        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
