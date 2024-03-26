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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RESTORANTTAKİP
{
    public partial class Garsonlar : Form
    {
        public Garsonlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=YUTPA;Initial Catalog=RestorantTakip;Integrated Security=True");
        private void Garsonlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restorantTakipDataSet.TBL_GARSON' table. You can move, or remove it, as needed.
            //this.tBL_GARSONTableAdapter.Fill(this.restorantTakipDataSet.TBL_GARSON);

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select*from TBL_GARSON",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBL_GARSON(GARSONADI,GARSONSOYADI,GARSONTELEFON,GARSONMAAS,GARSONCALiSMASAATi)VALUES(@P1,@P2,@P3,@P4,@P5)", baglanti);
            komut.Parameters.AddWithValue("@P1",txtgarsonadi.Text);
            komut.Parameters.AddWithValue("@P2", garsonsoyadi.Text);
            komut.Parameters.AddWithValue("@P3", txtgarsontelefonu.Text);
            komut.Parameters.AddWithValue("@P4", txtgarsonmaasi.Text);
            komut.Parameters.AddWithValue("@P5", txtgarsoncs.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Garson Başarıyla Eklenmiştir");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtgarsonid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtgarsonadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            garsonsoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtgarsontelefonu.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtgarsonmaasi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtgarsoncs.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From TBL_GARSON where garsonId=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",txtgarsonid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Garson Silinmiştir");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBL_GARSON SET GARSONADI=@p1,GARSONSOYADI=@p2,GARSONTELEFON=@p3,GARSONMAAS=@p4,GARSONCALiSMASAATi=@p5 where garsonId=@p6",baglanti);
                
            komut.Parameters.AddWithValue("@p1",txtgarsonadi.Text);
            komut.Parameters.AddWithValue("@p2",garsonsoyadi.Text);
            string textBoxValue = txtgarsontelefonu.Text;
            int.TryParse(textBoxValue, out int intValue);
            komut.Parameters.AddWithValue("@p3",intValue);
            string textBoxValue2 = txtgarsonmaasi.Text;
            int.TryParse(textBoxValue2, out int intValue2);
            komut.Parameters.AddWithValue("@p4", intValue2);
            string textBoxValue3 = txtgarsoncs.Text;
            int.TryParse(textBoxValue3, out int intValue3);
            komut.Parameters.AddWithValue("@p5", intValue3);
            komut.Parameters.AddWithValue("@p6",txtgarsonid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Garson Güncellenmiştir");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
//Data Source = YUTPA; Initial Catalog = RestorantTakip; Integrated Security = True