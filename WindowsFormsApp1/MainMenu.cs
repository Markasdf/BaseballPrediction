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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn1stLight_Click(object sender, EventArgs e)
        {
            btn1stLight.Visible = false;
            btn1st.Visible = true;
        }

        private void btn1st_Click(object sender, EventArgs e)
        {
            btn1st.Visible = false;
            btn1stLight.Visible = true;
        }

        private void btn2ndLight_Click(object sender, EventArgs e)
        {
            btn2ndLight.Visible = false;
            btn2nd.Visible = true;
        }

        private void btn2nd_Click(object sender, EventArgs e)
        {
            btn2nd.Visible = false;
            btn2ndLight.Visible = true;
        }

        private void btn3rdLight_Click(object sender, EventArgs e)
        {
            btn3rdLight.Visible = false;
            btn3rd.Visible = true;
        }

        private void btn3rd_Click(object sender, EventArgs e)
        {
            btn3rd.Visible = false;
            btn3rdLight.Visible = true;
        }

        private void btnInPlay_Click(object sender, EventArgs e)
        {
            InPlay l = new InPlay();
            l.Show();
            this.Hide();
        }
    }
}
