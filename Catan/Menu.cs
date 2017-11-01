using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catan
{
    public partial class Menu : Form
    {
        string[] pname = new string[6];
        int Mpoints = 0;
        public Menu()
        {
            InitializeComponent();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            if ()
            p1name.Text = pname[1]; // Opslag van speler namen.
            p2name.Text = pname[2];
            p3name.Text = pname[3];
            p4name.Text = pname[4];
            p5name.Text = pname[5];
            p6name.Text = pname[6];
            int mpoints = Convert.ToInt32(maxpoints.Text);

        }
        #region Players visible.

        private void Player2_CheckedChanged(object sender, EventArgs e)
        {
            //2 player mode.
            labelp1.Visible = true;
            labelp2.Visible = true;
            labelp3.Visible = false;
            labelp4.Visible = false;
            labelp5.Visible = false;
            labelp6.Visible = false;

        }


        private void Player3_CheckedChanged(object sender, EventArgs e)
        {
            // 3 player mode.
            labelp1.Visible = true;
            labelp2.Visible = true;
            labelp3.Visible = true;
            labelp4.Visible = false;
            labelp5.Visible = false;
            labelp6.Visible = false;
        }

        private void Player4_CheckedChanged(object sender, EventArgs e)
        {
            // 4 player mode.
            labelp1.Visible = true;
            labelp2.Visible = true;
            labelp3.Visible = true;
            labelp4.Visible = true;
            labelp5.Visible = false;
            labelp6.Visible = false;
        }

        private void Player5_CheckedChanged(object sender, EventArgs e)
        {
            // 5 player mode.
            labelp1.Visible = true;
            labelp2.Visible = true;
            labelp3.Visible = true;
            labelp4.Visible = true;
            labelp5.Visible = true;
            labelp6.Visible = false;
        }
        private void Player6_CheckedChanged(object sender, EventArgs e)
        {
            // 6 player mode.
            labelp1.Visible = true;
            labelp2.Visible = true;
            labelp3.Visible = true;
            labelp4.Visible = true;
            labelp5.Visible = true;
            labelp6.Visible = true;
        }

        #endregion
    }
}

