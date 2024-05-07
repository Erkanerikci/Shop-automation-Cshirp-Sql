using System.Data.SqlClient;

namespace MarketOtomasyonu
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=DARK;Initial Catalog=MarketOtomasyonu;Integrated Security=True"; // Veritabaný baðlantý dizesi
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi, ksifre;
            kadi = textBox1.Text;
            ksifre = textBox2.Text;


            connection.Open();
            SqlCommand sorgu = new SqlCommand("SELECT * FROM Admin where kullanici='" + kadi + "' and sifre='" + ksifre + "'", connection);
            SqlDataReader oku = sorgu.ExecuteReader();
            if (oku.Read())
            {
                Form2 admin = new Form2();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý Adý veya þifre hatalý");
            }



            connection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

