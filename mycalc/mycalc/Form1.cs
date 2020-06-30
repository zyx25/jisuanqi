using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycalc
{
    public partial class Formjisuanqi : Form
    {
        public Formjisuanqi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxop1.Text);
            var y = int.Parse(this.textBoxop2.Text);
            var z = x + y;
            this.lableresult.Text = z.ToString();
        }

        private void buttonjian_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxop1.Text);
            var y = int.Parse(this.textBoxop2.Text);
            var z = x - y;
            this.lableresult.Text = z.ToString();
        }

        private void buttoncheng_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxop1.Text);
            var y = int.Parse(this.textBoxop2.Text);
            var z = x * y;
            this.lableresult.Text = z.ToString();
        }

        private void buttonchu_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxop1.Text);
            var y = int.Parse(this.textBoxop2.Text);
            if (y != 0)
            {
                var z = x / y;
                this.lableresult.Text = z.ToString();
            }
            else
            {
                this.lableresult.Text = "0 不能作为除数";
            ; }       
        }
    }
}
