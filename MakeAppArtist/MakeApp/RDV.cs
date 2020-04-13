using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeApp
{
    public partial class RDV : UserControl
    {
        public RDV()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            BtnPrendre.Text = BtnPrendre.Text == "Prendre" ? "Annuler" : "Prendre";
        }
    }
}
