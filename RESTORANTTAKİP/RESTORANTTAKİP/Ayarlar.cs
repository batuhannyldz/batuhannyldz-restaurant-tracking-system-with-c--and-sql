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
    public partial class Ayarlar : Form

    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=YUTPA;Initial Catalog=RestorantTakip;Integrated Security=True");
        //veritabanı bağlantımızı yapıyoruz
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            //listele butonumuz için gerekli kodalrı yazıyoruz ve sql ile ilişkilendiriyoruz
            SqlCommand komut = new SqlCommand("select*from TBL_KULLANICILAR", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //kaydet butonumuz için gerekli kodalrı yazıyoruz ve sql ile ilişkilendiriyoruz
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBL_KULLANICILAR(KullanıcıAdı,KullanıcıSıfresi,KullanıcıSeviyesi,KullanıcıGörevi)VALUES(@P2,@P3,@P4,@P5)", baglanti);
          
            komut.Parameters.AddWithValue("@P2", txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@P3", txtkullanicisifre.Text);
            komut.Parameters.AddWithValue("@P4", txtkullaniciseviyesi.Text);
            komut.Parameters.AddWithValue("@P5", txtkullanicigorevi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı Başarıyla Eklenmiştir");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridwiew için gerekli bağlantıları yapıyoruz
            txtkullaniciadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtkullanicisifre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtkullaniciseviyesi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtkullanicigorevi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //sil butonumuz için gerekli kodalrı yazıyoruz ve sql ile ilişkilendiriyoruz
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From TBL_KULLANICILAR where kullanıcıadı=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtkullaniciadi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kullanıcı Silinmiştir");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            //guncelle butonumuz için gerekli kodalrı yazıyoruz ve sql ile ilişkilendiriyoruz
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBL_KULLANICILAR SET KullanıcıAdı=@p2,KullanıcıSıfresi=@p3,KullanıcıSeviyesi=@p4,KullanıcıGörevi=@p5 where kullanıcıadı=@p2", baglanti);
            
            komut.Parameters.AddWithValue("@p2", txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@p3", txtkullanicisifre.Text);
            komut.Parameters.AddWithValue("@p4", txtkullaniciseviyesi.Text);
            komut.Parameters.AddWithValue("@p5", txtkullanicigorevi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kullanıcı Güncellenmiştir");
        }

        private void btn_Garsonlar_Click(object sender, EventArgs e)
        {
            //garsonlar formumuzun başlangıç ayarlarını ve çağırılmasını yapıyoruz

            Garsonlar Form = new Garsonlar();
            Form.Location = new Point(0, 0);
            Form.Show();
        }

        private void btn_stok_Click(object sender, EventArgs e)
        {
            //stok formumuzun başlangıç ayarlarını ve çağırılmasını yapıyoruz

            StokDurumu Form = new StokDurumu();
            Form.Location = new Point(0, 0);
            Form.Show();
        }

        private void btn_mali_Click(object sender, EventArgs e)
        {
            //mali kayıtlar formumuzun başlangıç ayarlarını ve çağırılmasını yapıyoruz

            MaliKayıtlar Form = new MaliKayıtlar();
            Form.Location = new Point(0, 0);
            Form.Show();
        }

        private void btn_duzenleme_Click(object sender, EventArgs e)
        {
            //düzenle formumuzun başlangıç ayarlarını ve çağırılmasını yapıyoruz

            Düzenleme Form = new Düzenleme();
            Form.Location = new Point(0, 0);
            Form.Show();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {

        }
    }
}
