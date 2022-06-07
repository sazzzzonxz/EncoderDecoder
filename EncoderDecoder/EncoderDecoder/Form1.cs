using System;
using System.Windows.Forms;

namespace EncoderDecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.CryptType = CryptType.Atbash;

            form2.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.CryptType = CryptType.Caesar;

            form2.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.CryptType = CryptType.Vijner;

            form2.Show();
            //this.Hide();
        }
    }
}
