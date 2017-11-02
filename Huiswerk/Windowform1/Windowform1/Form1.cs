using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windowform1
{
    public partial class renteform : Form
    {
        double totaal;
        string tekst = "";
        int t = 0;
        public renteform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < 11; y++)
            {
                if (t == 0)
                {
                    tekst = tekst + "Na " + t + " jaar: " + bedragbox.Text + System.Environment.NewLine;
                    totaal = Convert.ToDouble(bedragbox.Text) * (1 + 0.01 * Convert.ToDouble(rentebox.Text));
                    t++;
                }
                else
                {
                    tekst = tekst + "Na " + y + " jaar: " + totaal + System.Environment.NewLine;
                    totaal = totaal * (1 + 0.01 * Convert.ToDouble(rentebox.Text));
                    totaal = System.Math.Round(totaal, 2);
                }
            }
            text.Text = Convert.ToString(tekst);
        }
    }
}
