using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafiklambalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.BackColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label1.Text);
            sayi++;
            label1.Text = sayi.ToString();
            if (sayi==30)
            {
                button2.BackColor = Color.Yellow;
                button1.BackColor = Color.Gray;
            }
            if (sayi==60)
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Green;

            }
            if (sayi==80)
            {
                sayi = 0;
                label1.Text = sayi.ToString();
                button1.BackColor = Color.Red;
                button3.BackColor = Color.Gray;
            }
        }
    }
}
