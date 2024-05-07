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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Reflection.Metadata;
using Document = iTextSharp.text.Document;
using com.itextpdf.text.pdf;

namespace MarketOtomasyonu
{
    public partial class Form14 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DARK;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            try
            {
                // Sütun başlıkları
                listBox1.Items.Add("Barkod No | Ürün Adı | Üretici | Fiyat | Stok");
                listBox2.Items.Add("Barkod No | Ürün Adı | Üretici | Fiyat | Stok");

                string sorgu = @"SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM yiyecek
                         UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM elektronik
                         UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM eglence
                         UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM icecek
                         UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM temizlik
                         UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM guzellik
                         UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM beyazesya
                         UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM giyim
                         UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM ayakkabı
                         UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM spor
                         UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM saglık";

                using (SqlConnection connection = new SqlConnection(baglanti.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sorgu, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            listBox1.Items.Add($"{reader["Barkod"]} | {reader["UrunAdı"]} | {reader["Uretici"]} | {reader["Fiyat"]} | {reader["Stok"]}");
                            
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri getirme hatası: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                string selectedProduct = listBox1.SelectedItem.ToString();
                int quantity = (int)numericUpDown1.Value;

                for (int i = 0; i < quantity; i++)
                {
                    listBox2.Items.Add(selectedProduct);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir ürün seçin!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double toplamFiyat = 0;

            foreach (string item in listBox2.Items)
            {
                string[] splitItem = item.Split('|');
                string fiyatString = splitItem[splitItem.Length - 2].Trim();

                if (double.TryParse(fiyatString, out double fiyat))
                {
                    toplamFiyat += fiyat;
                }
            }
            labeltoplam.Text = $"Toplam Fiyat: {toplamFiyat.ToString("C2")}";
        }
        private void YenileListBox1()
        {
            listBox1.Items.Clear();

            try
            {
                string sorgu = @"SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM yiyecek
             UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM elektronik
             UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM eglence
             UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM icecek
             UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM temizlik
             UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM guzellik
             UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM beyazesya
             UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM giyim
             UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM ayakkabı
             UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM spor
             UNION ALL SELECT Barkod,UrunAdı, Uretici, Stok, Fiyat FROM saglık";

                using (SqlConnection connection = new SqlConnection(baglanti.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sorgu, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            listBox1.Items.Add($"{reader["Barkod"]} | {reader["UrunAdı"]} | {reader["Uretici"]} | {reader["Fiyat"]} | {reader["Stok"]}");
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri getirme hatası: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> tabloAdlari = new Dictionary<string, string>
            {
                { "yiyecek", "yiyecek" },
                { "elektronik", "elektronik" },
                { "beyazesya", "beyazesya" },
                { "giyim", "giyim" },
                { "ayakkabı", "ayakkabı" },
                { "spor", "spor" },
                { "saglık", "saglık" },
                { "temizlik", "temizlik" },
                { "icecek", "icecek" },
                { "eglence", "eglence" },
                { "guzellik", "guzellik" }
            };

            // Fiş çıktısını oluştur
            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("------ Fis Ciktisi ------");

            foreach (string item in listBox2.Items)
            {
                string[] splitItem = item.Split('|');
                string barkod = splitItem[0].Trim();

                foreach (var tabloAdi in tabloAdlari.Values)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(@"Data Source=DARK;Initial Catalog=MarketOtomasyonu;Integrated Security=True"))
                        {
                            connection.Open();
                            string query = $"UPDATE {tabloAdi} SET Stok = Stok - 1 WHERE Barkod = @Barkod";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Barkod", barkod);
                                int affectedRows = command.ExecuteNonQuery();

                                if (affectedRows > 0)
                                {
                                    
                                    break;
                                }
                            }
                        }
                    }
                    
                    
                    catch (Exception ex)
                    {
                        
                    }
                }

                receipt.AppendLine(item);
            }
            receipt.AppendLine(labeltoplam.Text);
            receipt.AppendLine("-------------------------");

            try
            {
        
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Dosyaları|*.pdf";
                saveFileDialog.Title = "PDF Olarak Kaydet";
                saveFileDialog.ShowDialog();

                // Eğer kullanıcı bir dosya seçtiyse
                if (saveFileDialog.FileName != "")
                {
                    // PDF dokümanı oluştur
                    Document pdfDoc = new Document();
                    PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    pdfDoc.Open();

                    // Fiş çıktısını PDF'e yazdır
                    pdfDoc.Add(new Paragraph(receipt.ToString()));

                    pdfDoc.Close();
                    MessageBox.Show("Fiş çıktısı başarıyla PDF olarak kaydedildi: " + saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF oluşturma hatası: " + ex.Message);
            }

            listBox2.Items.Clear();
            YenileListBox1();

        }
    }
}