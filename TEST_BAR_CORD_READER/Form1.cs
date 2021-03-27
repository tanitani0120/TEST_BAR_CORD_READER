using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_BAR_CORD_READER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {
                e.Handled = true;
                long a = long.Parse(textBox1.Text);
                if (a == 4902850032339) {
                    textBox2.Text += "大阪から来ました谷口です\r\n";
                }
                else if (a == 4987601074646) {
                    textBox2.Text += "八尾市出身です\r\n";
                }
                
                textBox1.Text = "";
            }
        }
    }
}
