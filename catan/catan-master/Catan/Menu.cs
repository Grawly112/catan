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
        int maxpoints = 0;
        public Menu()
        {
            InitializeComponent();
        }
        string[] pname = new string[7];
        //int Mpoints = 0;



        public void startbtn_Click(object sender, EventArgs e)
        {
            if (!(maxp.Text == "") && (!(p1name.Text == "")) && (!(p2name.Text == "")) && (p3name.Visible == false || (!(p3name.Text == ""))) && (p4name.Visible
                == false || (!(p4name.Text==""))) && (p5name.Visible == false || (!(p5name.Text == ""))) && (p6name.Visible == false || (!(p6name.Text=="")))) 
            {
                p1name.Text = pname[1];                 // Opslag van speler namen.
                p2name.Text = pname[2];
                p3name.Text = pname[3];
                p4name.Text = pname[4];
                p5name.Text = pname[5];
                p6name.Text = pname[6];

                int mpoints = Convert.ToInt32(maxp.Text);
                
                BasicGame BGame = new BasicGame();      //start next forum.
                BGame.MdiParent = this.ParentForm;
                BGame.Show();


            }
            else
            {
                int x = 1;
                while (x <= 6)
                {
                    if (String.IsNullOrEmpty(pname[x]))
                    {
                        MessageBox.Show("You forgot something.");
                        
                    }
                    x++;
                }
               if (String.IsNullOrEmpty(maxp.Text))
                {
                    MessageBox.Show("You forgot to fill in the max score.");
                }

            }


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
        private void Player6_CheckedChanged_1(object sender, EventArgs e)
        {
            labelp1.Visible = true;
            labelp2.Visible = true;
            labelp3.Visible = true;
            labelp4.Visible = true;
            labelp5.Visible = true;
            labelp6.Visible = true;
        }


        #endregion

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        
    }
}

