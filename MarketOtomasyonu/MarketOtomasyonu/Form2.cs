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

namespace MarketOtomasyonu
{
    public partial class Form2 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form2()
        {
            InitializeComponent();
        }
        void MarketGetir()
        {
            baglanti = new SqlConnection(@"Data Source=DARK;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM yiyecek\r\nUNION ALL\r\nSELECT * FROM elektronik\r\nUNION ALL\r\nSELECT * FROM eglence\r\nUNION ALL\r\nSELECT * FROM icecek\r\nUNION ALL\r\nSELECT * FROM temizlik\r\nUNION ALL\r\nSELECT * FROM guzellik\r\nUNION ALL\r\nSELECT * FROM beyazesya\r\nUNION ALL\r\nSELECT * FROM giyim\r\nUNION ALL\r\nSELECT * FROM ayakkabı\r\nUNION ALL\r\nSELECT * FROM spor\r\nUNION ALL\r\nSELECT * FROM saglık;", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btnyiyecek_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnelektr_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void btneglence_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void btnicecek_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void btntemiz_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void btnguzel_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void btnbeyaz_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void btngiy_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void btnayak_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void btnspor_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void btnsaglık_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MarketGetir();
            dataGridView1.Columns["resim"].DefaultCellStyle.NullValue = null;
            dataGridView1.Columns["resim"].DefaultCellStyle.Padding = new Padding(-31);
            ((DataGridViewImageColumn)dataGridView1.Columns["resim"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void btngec_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
        }
    }
}
