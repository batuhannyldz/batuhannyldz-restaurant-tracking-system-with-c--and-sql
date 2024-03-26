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

namespace RESTORANTTAKİP
{

    public partial class Icecekler : Form
    {

        public Icecekler()
        {
            InitializeComponent();
            IcecekIsimleriniGuncelle();
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
        private void IcecekIsimleriniGuncelle()
        {
            string connectionString = "Data Source=YUTPA;Initial Catalog=RestorantTakip;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT icecekadı, icecekfiyati FROM tbl_Icecekler";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                int buttonIndex = 1;

                while (reader.Read() && buttonIndex <= 16)
                {
                    string icecekAdi = reader["icecekadı"].ToString();
                    int fiyat = Convert.ToInt32(reader["icecekfiyati"]);

                    Button btn = Controls.Find("button" + buttonIndex, true).FirstOrDefault() as Button;

                    if (btn != null)
                    {
                        btn.Text = $"{icecekAdi} - {fiyat:C}";
                        
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
               
                int icecekID = int.Parse(button.Name.Replace("button", ""));

                using (SqlConnection connection = new SqlConnection("Data Source=YUTPA;Initial Catalog=RestorantTakip;Integrated Security=True"))
                {
                    connection.Open();
                    StokDusur(connection, icecekID);
                }
            }
        }
        private void StokDusur(SqlConnection connection, int icecekID)
        {
            string sqlQuery = "UPDATE TBL_ICECEKLER SET icecekstok = icecekstok - 1 WHERE icecekID = @IcecekID";

            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                command.Parameters.AddWithValue("@IcecekID", icecekID);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    
                  
                    int currentStock = GetStokMiktari(connection, icecekID);

                    
                    if (currentStock < 0)
                    {
                        MessageBox.Show("Stok tükenmiştir!");
                    }
                }
                
            }
        }

        private int GetStokMiktari(SqlConnection connection, int icecekID)
        {
            string sqlQuery = "SELECT icecekstok FROM TBL_ICECEKLER WHERE icecekID = @IcecekID";

            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                command.Parameters.AddWithValue("@IcecekID", icecekID);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }

                return 0; 
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Icecekler_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);

        }
    }
    }

