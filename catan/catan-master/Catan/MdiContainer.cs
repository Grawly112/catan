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
    public partial class MdiContainer : Form
    {
        public MdiContainer()
        {
            InitializeComponent();
        }

        private void MdiContainer_Load(object sender, EventArgs e)
        {
            this.Text = "Memorygame";
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
            Close();
        }
    }
}
