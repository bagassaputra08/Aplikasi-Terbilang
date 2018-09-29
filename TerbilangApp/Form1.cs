using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TerbilangLibrary;

namespace TerbilangApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*private void button1_click(object sender, EventArgs e)
        {
            int nominal = int.Parse(textBox1.Text);
            Terbilang terbilang = new Terbilang();
            listBox1.Items.Clear();
            listBox1.Items.Add(terbilang.TerbilangIndonesia(nominal));
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            int nominal = int.Parse(textBox2.Text);
            Terbilang terbilang = new Terbilang();
            listBox2.Items.Clear();
            listBox2.Items.Add(terbilang.TerbilangIndonesia(nominal));
        }
    }
}
