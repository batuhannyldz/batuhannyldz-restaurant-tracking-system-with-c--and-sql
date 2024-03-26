using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using RESTORANTTAKİP;

namespace RESTORANTTAKİP
{
    public partial class Form1 : Form
    {
       //mdi formlarımız ve de kullanıcı seviyesi için gerekli olan değişkenlerimizi tanımlıyoruz
        private masalar childForm1;
        private Icecekler childForm2;
        private Yemekler childForm3;
        public static int kullaniciSeviyesi;
        //sql bağlantımızı yapıyoruz
        string connectionString = "Data Source=YUTPA;Initial Catalog=RestorantTakip;Integrated Security=True";

        public Form1()
        {
           

            InitializeComponent();
        }
        //formlar arası veri alışverişi için tanımlamamızı yapıyoruz bu veri bize logğin ekranından geliyor
        public static void SetKullaniciSeviyesi(int seviye)
        {
            kullaniciSeviyesi = seviye;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //uygulama açıldığında masalar formunun açılması için load kısmına masalr formunu mdi olarak tanımlıyoruz
            masalar cocukForm = new masalar();
            cocukForm.MdiParent = this;
            cocukForm.Location = new Point(0, 0);
            // Çocuk formu göster
            cocukForm.Show();
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (childForm1 == null || childForm1.IsDisposed)//ana form üzerinde mdi formlar birbinin üstüne çıkmaması için almış oldğum önlem arka planda herhangi bir mdi form açıksa kapat
            {
                childForm1 = new masalar();
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
            if (childForm3 != null && !childForm3.IsDisposed)
            {
                childForm1.Location = new Point(0, 0);
                childForm3.Close();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (childForm3 == null || childForm3.IsDisposed)
            {
                childForm3 = new Yemekler();
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
        private void button3_Click(object sender, EventArgs e)
        {
            if (childForm2 == null || childForm2.IsDisposed)
            {
                childForm2 = new Icecekler();
                childForm2.MdiParent = this; // Ana formu belirt
                childForm2.Location = new Point(0, 0);
                childForm2.Show();

            }
            else
            {
                childForm2.Location = new Point(0, 0);

                // Eğer childForm2 zaten açıksa, sadece ön plana getir
                childForm2.Activate();


            }

            // Eğer childForm1 açıksa, kapat
            if (childForm1 != null && !childForm1.IsDisposed)
            {
                childForm2.Location = new Point(0, 0);

                childForm1.Close();

            }
            if (childForm3 != null && !childForm3.IsDisposed)
            {
                childForm2.Location = new Point(0, 0);
                childForm3.Close();

            }


        }
        //burada biraz sarmal bi yapı oluştu bunu oop ile önleyebiliriz ancak yeterli bilgim olmadığı için maalesef es geçildi temiz kod olmadı ama çalışıyorsa elleme
        private void button4_Click(object sender, EventArgs e)
        {
            if (kullaniciSeviyesi == 1 || kullaniciSeviyesi == 2)//kullanıcı seviyelerinin düzenlenmesi için alınan bir önlem
            {
                Garsonlar Form = new Garsonlar();
                Form.Location = new Point(0, 0);
                Form.Show();
            }
            else
            {

                MessageBox.Show("Yetkisiz deneme! Garsonlar butonuna erişim izniniz yok.");
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (kullaniciSeviyesi == 1 || kullaniciSeviyesi==2)
            {
                StokDurumu Form = new StokDurumu();
                Form.Location = new Point(0, 0);
                Form.Show();
            }
            else
            {

                MessageBox.Show("Yetkisiz deneme! Stok Durumu butonuna erişim izniniz yok.");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (kullaniciSeviyesi == 1)
            {



                using (SqlConnection connection = new SqlConnection(connectionString))
               
                using (SqlCommand command = new SqlCommand("UpdateVergiProcedure", connection))//burada sp mizi çağırıyoruz
                        {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                            command.ExecuteNonQuery();
                          
                        }
                    
                   
                    MaliKayıtlar Form = new MaliKayıtlar();
                Form.Location = new Point(0, 0);
                Form.Show();
            }
            else
            {

                MessageBox.Show("Yetkisiz deneme! Mali Kayıtlar butonuna erişim izniniz yok.");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (kullaniciSeviyesi == 1)
            {
                Ayarlar Form = new Ayarlar();
                Form.Location = new Point(0, 0);
                Form.Show();
            }
            else
            {
               
                MessageBox.Show("Yetkisiz deneme! Ayarlar butonuna erişim izniniz yok.");
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (kullaniciSeviyesi == 1)
            {
                Düzenleme Form = new Düzenleme();
                Form.Location = new Point(0, 0);
                Form.Show();
            }
            else
            {

                MessageBox.Show("Yetkisiz deneme! Düzenleme butonuna erişim izniniz yok.");
            }

        }
    }
}
