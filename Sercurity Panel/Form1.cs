using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sercurity_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text =textBox1.Text+ "1";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text.Length>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }
        private async Task button3_ClickAsync(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            if(int.Parse(textBox1.Text)==6990 || int.Parse(textBox1.Text)==6999)
            {                
                textBox2.AppendText (date.ToLongTimeString() + " Technicians \r\n" );
            }
            else if(int.Parse(textBox1.Text)==0100)
            {
                textBox2.AppendText (date.ToLongTimeString() + " Custodian \r\n");
            }
            else if(int.Parse(textBox1.Text) == 9998 || (int.Parse(textBox1.Text) >= 1006 && int.Parse(textBox1.Text) <= 1008))
            {
                textBox2.AppendText (date.ToLongTimeString() + " Scientist \r\n");
            }
            else
            {
                textBox2.AppendText (date.ToLongTimeString() + " Restricted Access \r\n");
            }
            textBox1.Text = "";
            string text = textBox2.Text;
             File.WriteAllText("D:\\WriteText.txt", text);


        }
    }
}
