using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTORANTTAKİP
{
    public partial class masalar : Form
    {
        public masalar()
        {
            InitializeComponent();
        }

        private void KontrolButtonRengi(Button button, string labelText)
        {
            if (!string.IsNullOrEmpty(labelText)) // Eğer Label1'in metni boş değilse
            {
                button.BackColor = Color.Red; // Buton rengini kırmızı yap
            }
            else
            {
                button.BackColor = Color.YellowGreen; // Buton rengini yeşil yap
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Masa1 masa1Form = new Masa1();
            // Masa1 formunu açmak için
            masa1Form.ShowDialog();
            // Masa1 formundaki label1 kontrolünün durumunu kontrol etmek için
            KontrolButtonRengi(button1, masa1Form.LabelText);
            masa1Form.Location = new Point(0, 0);
        }

        private void masalar_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);

        }
    }
}
