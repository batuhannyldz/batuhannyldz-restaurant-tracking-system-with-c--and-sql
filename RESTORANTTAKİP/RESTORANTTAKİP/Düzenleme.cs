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
    public partial class Düzenleme : Form
    {
        public Düzenleme()
        {
            InitializeComponent();
        }
        //sql bağlantımızı yapıyoruz
        SqlConnection baglanti = new SqlConnection(@"Data Source=YUTPA;Initial Catalog=RestorantTakip;Integrated Security=True");

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            //listele butonumuz için gerekli bağlantıları yapıyoruz
            SqlCommand komut = new SqlCommand("select*from TBL_STOK", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridwiew için gerekli bağlantıları yapıyoruz
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtfiyati.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtstok.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtkategori.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();
            if (txtkategori.Text=="Yemek") {//eğerki eklediğimiz ürün yemek ise ınsert yemek sp mizi çağırıyoruz ve gerekli bağlantıları dönüşümleri yapıyoruz
                SqlCommand komut = new SqlCommand("InsertYemek", baglanti);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@YemekAdi", txtadi.Text);
                komut.Parameters.AddWithValue("@YemekFiyati", int.Parse(txtfiyati.Text));
                komut.Parameters.AddWithValue("@YemekStok", int.Parse(txtstok.Text));

                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Yemek Başarıyla Eklenmiştir");
            }
            else if (txtkategori.Text == "İçecek")//eğerki eklediğimiz ürün içecek ise ınsert içcecek sp mizi çağırıyoruz ve gerekli bağlantıları dönüşümleri yapıyoruz
            {
                SqlCommand komut = new SqlCommand("InsertIcecek", baglanti);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@IcecekAdi", txtadi.Text);
                komut.Parameters.AddWithValue("@IcecekFiyati", int.Parse(txtfiyati.Text));
                komut.Parameters.AddWithValue("@IcecekStok", int.Parse(txtstok.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("İcecek Başarıyla Eklenmiştir");
            }
            
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            //güncelle butonumuz için gerekli bağlantıları yapıyourz
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBL_STOK SET URUNADI=@p1,URUNFIYATI=@p2,URUNSTOK=@p3,URUNKATEGORİ=@p4 where URUNID=@p5", baglanti);

            komut.Parameters.AddWithValue("@p1", txtadi.Text);
            komut.Parameters.AddWithValue("@p2", txtfiyati.Text);
            komut.Parameters.AddWithValue("@p3", txtstok.Text);
            komut.Parameters.AddWithValue("@p4", txtkategori.Text);
            komut.Parameters.AddWithValue("@p5", txtid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Güncellenmiştir");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {//sil butonumuz için gerekli bağlantıları yapıyourz
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From TBL_STOK where URUNID=@p1 AND URUNKATEGORİ=@P2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.Parameters.AddWithValue("@p2", txtkategori.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Silinmiştir");
        }

        private void Düzenleme_Load(object sender, EventArgs e)
        {

        }
    }
}
