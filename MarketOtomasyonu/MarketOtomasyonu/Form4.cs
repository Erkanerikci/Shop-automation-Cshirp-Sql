using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class Form4 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MarketGetir();
            dataGridView1.Columns["resim"].DefaultCellStyle.NullValue = null;
            dataGridView1.Columns["resim"].DefaultCellStyle.Padding = new Padding(-31);
            ((DataGridViewImageColumn)dataGridView1.Columns["resim"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        void MarketGetir()
        {
            baglanti = new SqlConnection(@"Data Source=DARK;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM elektronik", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtbarkod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtfirma.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtfiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtstok.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            byte[] imageData = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
            pictureBox1.Image = ByteArrayToImage(imageData);
        }

        private void btnfoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            btnfoto.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] imageData = ImageToByteArray(pictureBox1.Image);
            string sorgu = "INSERT INTO elektronik(Barkod, UrunAdı, Uretici, Fiyat,Stok, resim) VALUES(@Barkod, @UrunAdı, @Uretici, @Fiyat,@Stok, @resim)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Barkod", txtbarkod.Text);
            komut.Parameters.AddWithValue("@UrunAdı", txtad.Text);
            komut.Parameters.AddWithValue("@Uretici", txtfirma.Text);
            komut.Parameters.AddWithValue("@Fiyat", txtfiyat.Text);
            komut.Parameters.AddWithValue("@Stok", txtstok.Text);
            komut.Parameters.Add("@resim", SqlDbType.VarBinary, -1).Value = imageData;
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MarketGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM elektronik WHERE Barkod=@Barkod";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Barkod", Convert.ToInt32(txtbarkod.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MarketGetir();
        }
        private bool AreImagesEqual(Image image1, Image image2)
        {
            if (image1.Width != image2.Width || image1.Height != image2.Height)
            {
                return false;
            }

            using (MemoryStream ms1 = new MemoryStream())
            using (MemoryStream ms2 = new MemoryStream())
            {
                image1.Save(ms1, ImageFormat.Png);
                image2.Save(ms2, ImageFormat.Png);

                byte[] image1Bytes = ms1.ToArray();
                byte[] image2Bytes = ms2.ToArray();

                return StructuralComparisons.StructuralEqualityComparer.Equals(image1Bytes, image2Bytes);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Barkod = txtbarkod.Text;
            string yeniAd = txtad.Text;
            string yeniFirma = txtfirma.Text;
            string yeniFiyat = txtfiyat.Text;
            string yeniStok = txtstok.Text;


            byte[] currentImageData = GetImageFromDatabase(Convert.ToInt32(Barkod));
            Image eskiresim = ByteArrayToImage(currentImageData);

            Image yeniresim = pictureBox1.Image;

            byte[] yeniresimBytes;
            if (!AreImagesEqual(yeniresim, eskiresim))
            {
                yeniresimBytes = ImageToByteArray(yeniresim);
            }
            else
            {
                yeniresimBytes = currentImageData;
            }

            string connectionString = "Data Source=DARK;Initial Catalog=MarketOtomasyonu;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string kontrolQuery = "SELECT COUNT(*) FROM elektronik WHERE Barkod = @Barkod";

                using (SqlCommand kontrolCommand = new SqlCommand(kontrolQuery, connection))
                {
                    kontrolCommand.Parameters.AddWithValue("@Barkod", Barkod);

                    int elektronikSayisi = (int)kontrolCommand.ExecuteScalar();

                    if (elektronikSayisi > 0)
                    {
                        string guncellemeQuery = "UPDATE elektronik SET UrunAdı = @yeniAd, Uretici = @yeniFirma, Fiyat = @yeniFiyat, resim = @Yeniresim WHERE Barkod = @Barkod";

                        using (SqlCommand guncellemeCommand = new SqlCommand(guncellemeQuery, connection))
                        {
                            guncellemeCommand.Parameters.AddWithValue("@Barkod", Barkod);
                            guncellemeCommand.Parameters.AddWithValue("@yeniAd", yeniAd);
                            guncellemeCommand.Parameters.AddWithValue("@yeniFirma", yeniFirma);
                            guncellemeCommand.Parameters.AddWithValue("@yeniFiyat", yeniFiyat);
                            guncellemeCommand.Parameters.AddWithValue("@yeniStok", yeniStok);
                            guncellemeCommand.Parameters.Add("@Yeniresim", SqlDbType.VarBinary, -1).Value = yeniresimBytes;

                            guncellemeCommand.ExecuteNonQuery();

                            MessageBox.Show("Öğrenci bilgileri ve resmi başarıyla güncellendi.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bulunamadı. Lütfen geçerli bir öğrenci numarası girin.");
                    }
                }
            }

            MarketGetir();
        }
        private byte[] GetImageFromDatabase(int Barkod)
        {
            byte[] imageData = null;
            string connectionString = "Data Source=DARK;Initial Catalog=MarketOtomasyonu;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT resim FROM elektronik WHERE Barkod = @Barkod";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Barkod", Barkod);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                imageData = (byte[])reader[0];
                            }
                        }
                    }
                }
            }

            return imageData;
        }


        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return new Bitmap(image);
            }
        }

        
    }
    

}
