using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RESTORANTTAKİP
{
    public partial class Masa1 : Form
    {

        public string LabelText
        {
            get { return label1.Text; }
        }
        public event EventHandler LabelTextChanged;

        string connectionString = "Data Source=YUTPA;Initial Catalog=RestorantTakip;Integrated Security=True";
        public Masa1()
        {
            InitializeComponent();

        }

        public void GuncelleLabel(string yeniIcerik)
        {
            label1.Text += yeniIcerik + Environment.NewLine;
            YazMasaSiparis(label1.Text);
        }

        private Yemekler childForm1;
        private masalar childForm2;
        private Icecekler childForm3;
        private void btnyemekler_Click(object sender, EventArgs e)
        {
            if (childForm1 == null || childForm1.IsDisposed)
            {
                childForm1 = new Yemekler();
                childForm1.MdiParent = this;
                // Ana formu belirt
                childForm1.Location = new Point(0, 0);

                childForm1.Show();

            }
            else
            {
                childForm1.Location = new Point(0, 0);
                // Eğer childForm1 zaten açıksa, sadece ön plana getir
                childForm1.Activate();


            }

            // Eğer childForm2 açıksa, kapat
            if (childForm2 != null && !childForm2.IsDisposed)
            {
                childForm1.Location = new Point(0, 0);
                childForm2.Close();

            }
        }

        private void btnicecekler_Click(object sender, EventArgs e)
        {
            if (childForm3 == null || childForm3.IsDisposed)
            {
                childForm3 = new Icecekler();
                childForm3.MdiParent = this; // Ana formu belirt
                childForm3.Location = new Point(0, 0);
                childForm3.Show();

            }
            else
            {
                childForm3.Location = new Point(0, 0);

                // Eğer childForm2 zaten açıksa, sadece ön plana getir
                childForm3.Activate();


            }

            // Eğer childForm1 açıksa, kapat
            if (childForm2 != null && !childForm2.IsDisposed)
            {
                childForm3.Location = new Point(0, 0);

                childForm2.Close();



            }
            if (childForm1 != null && !childForm1.IsDisposed)
            {
                childForm3.Location = new Point(0, 0);

                childForm1.Close();



            }
        }


        private void YazMasaSiparis(string siparis)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE tbl_masalar SET masa_siparis = @MasaSiparis WHERE masa_adi = @MasaAdi";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MasaAdi", "masa1"); // Masa adını güncelleyin
                        command.Parameters.AddWithValue("@MasaSiparis", siparis);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        private void CekMasaSiparis()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT masa_siparis FROM tbl_masalar WHERE masa_adi = @MasaAdi";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MasaAdi", "masa1"); // Masa adını güncelleyin

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            label1.Text = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }
        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Siparişler_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Masa1_Load(object sender, EventArgs e)
        {
            childForm1 = new Yemekler();
            childForm1.MdiParent = this;
            // Ana formu belirt
            childForm1.Location = new Point(0, 0);

            childForm1.Show();
            CekMasaSiparis();


            // SQL sorgusu
            string sqlQuery = "SELECT masatutarı FROM tbl_masalar WHERE MasaNo = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Sorgudan bir değer alınması bekleniyor.
                    object result = command.ExecuteScalar();

                    // Eğer değer alındıysa ve değer null değilse label'a atama yapılır.
                    if (result != null)
                    {
                        labelhesap.Text = result.ToString();
                    }
                    else
                    {
                        // Eğer değer alınamazsa bir hata mesajı gösterilebilir.
                        MessageBox.Show("Masatutarı değeri alınamadı.");
                    }
                }
            }
        }



        private void btnsil_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            labelhesap.Text = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE tbl_masalar SET MasaTutarı = @siparis where MasaNo=1 ", connection))
                {
                    command.Parameters.AddWithValue("@siparis", string.Empty);
                    command.ExecuteNonQuery();
                }
            }
            YazMasaSiparis(string.Empty);
        }

        private void labelhesap_Click(object sender, EventArgs e)
        {

        }
        int GunsonuHesabı;
        private void BtnNakit_Click(object sender, EventArgs e)
        {
            string label1Metni = label1.Text;

            // Toplamı tutacak değişken
            decimal toplam = 0;

            // Satırları boşluk, çizgi gibi karakterlere göre bölelim
            string[] satirlar = label1Metni.Split(new char[] { ' ', '\n', '\r', '\t', '-' }, StringSplitOptions.RemoveEmptyEntries);

            // Her bir satırı kontrol edelim
            foreach (string satir in satirlar)
            {
                // Satırın içinde '₺' sembolü varsa ve geri kalan kısmı bir sayıysa toplama ekleyelim
                if (satir.Contains("₺") && decimal.TryParse(satir.Replace("₺", ""), out decimal satirDegeri))
                {
                    toplam += satirDegeri;
                }
            }

            labelhesap.Text = "Hesap:" + toplam.ToString("N2", CultureInfo.InvariantCulture) + "₺";
            GunsonuHesabı = (int)toplam;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE tbl_masalar SET MasaTutarı = @siparis where MasaNo=1 ", connection))
                {
                    command.Parameters.AddWithValue("@siparis", labelhesap.Text);
                    command.ExecuteNonQuery();
                }
            }
        }
        

        private void btnhesapal_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("GunsonuHesap", connection))
                {
                    connection.Open();

                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    
                    command.Parameters.AddWithValue("@hesap", GunsonuHesabı); 

                    command.ExecuteNonQuery();

                }
            }

        }
    }
}

