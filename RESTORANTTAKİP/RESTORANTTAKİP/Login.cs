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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RESTORANTTAKİP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=YUTPA;Initial Catalog=RestorantTakip;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_KULLANICILAR WHERE KullanıcıSeviyesi=@p1 and KullanıcıAdı=@p2 and kullanıcıSıfresi=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1",txtloginid.Text);
            komut.Parameters.AddWithValue("@p2", txtloginkadi.Text);
            komut.Parameters.AddWithValue("@p3", txtloginsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                int kullaniciSeviyesi = Convert.ToInt32(txtloginid.Text);

                Form1 form1 = new Form1();
                Form1.SetKullaniciSeviyesi(kullaniciSeviyesi);
                
                form1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş Denemesi");
            }
            baglanti.Close();
            
          
        }
        string connectionString = "Data Source=YUTPA;Initial Catalog=RestorantTakip;Integrated Security=True";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void btnyenigun_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(("EXEC YENIGUN"), connection))
                {
                    
                    command.ExecuteNonQuery();
                }
            }

        }
    }    
}
