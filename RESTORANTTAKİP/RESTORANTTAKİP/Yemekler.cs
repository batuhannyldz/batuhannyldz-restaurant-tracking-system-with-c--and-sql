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

namespace RESTORANTTAKİP
{
    public partial class Yemekler : Form
    {

        
        public Yemekler()
        {
            InitializeComponent();
            YemekIsimleriniGuncelle();
            button1.Click += Buton_Click;
            button2.Click += Buton_Click;
            button3.Click += Buton_Click;
            button4.Click += Buton_Click;
            button5.Click += Buton_Click;
            button6.Click += Buton_Click;
            button7.Click += Buton_Click;
            button8.Click += Buton_Click;
            button9.Click += Buton_Click;
            button10.Click += Buton_Click;
            button11.Click += Buton_Click;
            button12.Click += Buton_Click;
            button13.Click += Buton_Click;
            button14.Click += Buton_Click;
            button15.Click += Buton_Click;
            button16.Click += Buton_Click;


        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=YUTPA;Initial Catalog=RestorantTakip;Integrated Security=True");
        
        private void YemekIsimleriniGuncelle()
        {
            string connectionString = "Data Source=YUTPA;Initial Catalog=RestorantTakip;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT yemekadı, yemekfiyatı FROM tbl_yemekler";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                int buttonIndex = 1;

                while (reader.Read() && buttonIndex <= 16)
                {
                    string yemekAdi = reader["yemekadı"].ToString();
                    int fiyat = Convert.ToInt32(reader["yemekfiyatı"]);
                

                    
                    Button btn = Controls.Find("button" + buttonIndex, true).FirstOrDefault() as Button;

                    if (btn != null)
                    {
                        btn.Text = $"{yemekAdi} - {fiyat:C}";
                    }

                    buttonIndex++;
                }

                reader.Close();
            }
        }

        private void Buton_Click(object sender, EventArgs e)
        {
            Button tiklananButon = sender as Button;

            if (tiklananButon != null)
            {
                Masa1 masa1Form = Application.OpenForms.OfType<Masa1>().FirstOrDefault();
                if (masa1Form == null)
                {
                    masa1Form = new Masa1();
                    masa1Form.MdiParent = this.MdiParent;
                    masa1Form.Show();
                }

                masa1Form.GuncelleLabel($"{tiklananButon.Text} ");
            }
            if (sender is Button button)
            {
              
                int yemekID = int.Parse(button.Name.Replace("button", ""));

                using (SqlConnection connection = new SqlConnection("Data Source=YUTPA;Initial Catalog=RestorantTakip;Integrated Security=True"))
                {
                    connection.Open();
                    StokDusur(connection, yemekID);
                }
            }


        }
        private void StokDusur(SqlConnection connection, int yemekID)
        {
            string sqlQuery = "UPDATE tbl_yemekler SET yemekstok = yemekstok - 1 WHERE yemekID = @YemekID";

            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                command.Parameters.AddWithValue("@YemekID", yemekID);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    int currentStock = GetStokMiktari(connection, yemekID);

                    // Eğer stok miktarı 0'dan küçükse uyarı ver
                    if (currentStock < 0)
                    {
                        MessageBox.Show("Stok tükenmiştir!");
                    }
                }
                
            }
        }
        private int GetStokMiktari(SqlConnection connection, int yemekID)
        {
            string sqlQuery = "SELECT yemekstok FROM tbl_yemekler WHERE yemekID = @YemekID";

            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                command.Parameters.AddWithValue("@YemekID", yemekID);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }

                return 0; 
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {


        }
         
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Yemekler_Load(object sender, EventArgs e)
        {
            
            this.Location = new Point(0, 0);

        }
    }
}
