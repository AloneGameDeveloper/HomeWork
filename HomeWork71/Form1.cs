using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Гажим Дариус

namespace HomeWork71
{
    public partial class Form1 : Form
    {
        int Number, Num;

        public Form1()
        {
            Random r = new Random();
            Num = r.Next(1, 100);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = Num.ToString();
            Number = Convert.ToInt32(textBox1.Text);

            if (Number < Num)
            {
                label1.Text = "less";
            }
            else if (Number > Num)
            {
                label1.Text = "greater";
            }
            else if (Number == Num)
            {
                label1.Text = "Win";
            }
        }
    }
}
