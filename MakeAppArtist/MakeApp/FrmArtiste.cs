using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeApp
{
    public partial class FrmArtiste : Form
    {
        private Guna.UI.Lib.ScrollBar.PanelScrollHelper vScrollHelper2;
        public FrmArtiste()
        {
            InitializeComponent();            
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            gunaCirclePictureBox4.Visible = false;
            gunaCirclePictureBox3.Visible = false;
            gunaCirclePictureBox2.Visible = true;
            pnlProfil.Visible = false;
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            gunaCirclePictureBox4.Visible = true;
            gunaCirclePictureBox3.Visible = false;
            gunaCirclePictureBox2.Visible = false;
            pnlProfil.Visible = true;
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            gunaCirclePictureBox4.Visible = false;
            gunaCirclePictureBox3.Visible = true;
            gunaCirclePictureBox2.Visible = false;
            pnlProfil.Visible = false;
        }



        private void FrmArtiste_Load_1(object sender, EventArgs e)
        {
            vScrollHelper2 = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnlHome, gunaVScrollBar1, true);
            
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            this.pnlFull.Visible = false;
            Func.Animate(panel13, 7, 124);
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            Func.Animate(panel13, 7, 229);
            this.pnlFull.Visible = true;
        }
    }
}
