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

namespace RESTORANTTAKİP
{
    public partial class StokDurumu : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=YUTPA;Initial Catalog=RestorantTakip;Integrated Security=True");

        public StokDurumu()
        {
            InitializeComponent();
        }
        private void StokDurumu_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Execute STOKKONTROL",baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
    }
}
