using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class AtBat : Form
	{

		public AtBat()
		{
			InitializeComponent();
		}

        int balls = 0;
        int strikes = 0;
        int outs = 0;
		private void button1_Click(object sender, EventArgs e)
		{
            if (balls < 4)
            {
                balls++;
                label1.Text = balls.ToString();
            }
            else
            {
                label1.Text = balls.ToString();
            }
        }

		private void label1_Click(object sender, EventArgs e)
		{

		}

        private void button2_Click(object sender, EventArgs e)
        {
            if (strikes < 2)
            {
                strikes++;
                label2.Text = strikes.ToString();
            }
            else
            {
                outs++;
                label2.Text = outs.ToString();
                Players b = new Players();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
