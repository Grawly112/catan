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
    public partial class BasicGame : Form
    {

        int[] worpen = new int[12];

        int[] steden = new int[4];
        int[] dorpen = new int [5];
        int[] scores = new int[6];
        
        


        #region grondstoffen
        int[] hout = new int [6];
        int[] steen = new int[6];
        int[] graan = new int[6];
        int[] erts = new int[6];
        int[] schaap = new int[6];
#endregion
        public void Menu(string pname1, string pname2, string pname3, string pname4, string pname5, string pname6)
        {
            player1.Text = pname1;
            player2.Text = pname2;
            player3.Text = pname3;
            player4.Text = pname4;
            player5.Text = pname5;
            player6.Text = pname6;


            scores[1] = 0;
            scores[2] = 0;
            scores[3] = 0;
            scores[4] = 0;
            scores[5] = 0;
            scores[6] = 0;
            scorelabel1.Text = "score:" + scores[1]; // score word hier getoond.
            scorelabel2.Text = "score:" + scores[2]; 
            scorelabel3.Text = "score:" + scores[3]; 
            scorelabel4.Text = "score:" + scores[4]; 
            scorelabel5.Text = "score:" + scores[5]; 
            scorelabel6.Text = "score:" + scores[6]; 



        }

        public BasicGame()
        {

            
            InitializeComponent();
        }


    }
}
