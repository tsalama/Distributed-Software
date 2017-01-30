using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Encryption.ServiceClient proxy = new Encryption.ServiceClient();

            label5.Text = proxy.Encrypt(textBox2.Text);
            label6.Text = proxy.Decrypt(label5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stock.ServiceClient proxy = new Stock.ServiceClient();

            label10.Text = "$" + proxy.getStockquote(textBox3.Text);
        }
    }
}
