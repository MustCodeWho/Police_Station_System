using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_System_I
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            btnAct.IdleFillColor = Color.White;
            btnAct.IdleForecolor = Color.DodgerBlue;
            gunaImageButton1.BackColor = Color.White;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            uC_Acceuil1.Visible = true;
            uC_Acceuil1.BringToFront();
            btnAct.IdleFillColor = Color.White;
            btnAct.IdleForecolor = Color.DodgerBlue;
            btnOff.IdleFillColor = Color.DodgerBlue;
            btnOff.IdleForecolor = Color.White;
            btnCri.IdleFillColor = Color.DodgerBlue;
            btnCri.IdleForecolor = Color.White;
            btnCas.IdleFillColor = Color.DodgerBlue;
            btnCas.IdleForecolor = Color.White;
            btnRech.IdleFillColor = Color.DodgerBlue;
            btnRech.IdleForecolor = Color.White;
            btnImprimer.IdleFillColor = Color.DodgerBlue;
            btnImprimer.IdleForecolor = Color.White;
            gunaImageButton1.BackColor = Color.White;
            gunaImageButton2.BackColor = Color.DodgerBlue;
            gunaImageButton3.BackColor = Color.DodgerBlue;
            gunaImageButton4.BackColor = Color.DodgerBlue;
            gunaImageButton5.BackColor = Color.DodgerBlue;
            gunaImageButto5.BackColor = Color.DodgerBlue;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ask2 a2 = new ask2();
            a2.ShowDialog();
            
        }


        private void uC_Officier1_Load(object sender, EventArgs e)
        {

        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            
            uC_Officiers1.Visible = true;
            uC_Officiers1.BringToFront();
            btnOff.IdleFillColor = Color.White;
            btnOff.IdleForecolor = Color.DodgerBlue;
            btnAct.IdleFillColor = Color.DodgerBlue;
            btnAct.IdleForecolor = Color.White;
            btnCri.IdleFillColor = Color.DodgerBlue;
            btnCri.IdleForecolor = Color.White;
            btnCas.IdleFillColor = Color.DodgerBlue;
            btnCas.IdleForecolor = Color.White;
            btnRech.IdleFillColor = Color.DodgerBlue;
            btnRech.IdleForecolor = Color.White;
            btnImprimer.IdleFillColor = Color.DodgerBlue;
            btnImprimer.IdleForecolor = Color.White;
            gunaImageButton1.BackColor = Color.DodgerBlue;
            gunaImageButton2.BackColor = Color.White;
            gunaImageButton3.BackColor = Color.DodgerBlue;
            gunaImageButton4.BackColor = Color.DodgerBlue;
            gunaImageButton5.BackColor = Color.DodgerBlue;
            gunaImageButto5.BackColor = Color.DodgerBlue;

        }

        private void uC_Criminel1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
            uC_Criminel1.Visible = true;
            uC_Criminel1.BringToFront();
            btnCri.IdleFillColor = Color.White;
            btnCri.IdleForecolor = Color.DodgerBlue;
            btnAct.IdleFillColor = Color.DodgerBlue;
            btnAct.IdleForecolor = Color.White;
            btnOff.IdleFillColor = Color.DodgerBlue;
            btnOff.IdleForecolor = Color.White;
            btnCas.IdleFillColor = Color.DodgerBlue;
            btnCas.IdleForecolor = Color.White;
            btnRech.IdleFillColor = Color.DodgerBlue;
            btnRech.IdleForecolor = Color.White;
            btnImprimer.IdleFillColor = Color.DodgerBlue;
            btnImprimer.IdleForecolor = Color.White;
            gunaImageButton1.BackColor = Color.DodgerBlue;
            gunaImageButton2.BackColor = Color.DodgerBlue;
            gunaImageButton3.BackColor = Color.White;
            gunaImageButton4.BackColor = Color.DodgerBlue;
            gunaImageButton5.BackColor = Color.DodgerBlue;
            gunaImageButto5.BackColor = Color.DodgerBlue;

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            
            uC_Crime1.Visible = true;
            uC_Crime1.BringToFront();
            btnCas.IdleFillColor = Color.White;
            btnCas.IdleForecolor = Color.DodgerBlue;
            btnAct.IdleFillColor = Color.DodgerBlue;
            btnAct.IdleForecolor = Color.White;
            btnOff.IdleFillColor = Color.DodgerBlue;
            btnOff.IdleForecolor = Color.White;
            btnCri.IdleFillColor = Color.DodgerBlue;
            btnCri.IdleForecolor = Color.White;
            btnRech.IdleFillColor = Color.DodgerBlue;
            btnRech.IdleForecolor = Color.White;
            btnImprimer.IdleFillColor = Color.DodgerBlue;
            btnImprimer.IdleForecolor = Color.White;
            gunaImageButton1.BackColor = Color.DodgerBlue;
            gunaImageButton2.BackColor = Color.DodgerBlue;
            gunaImageButton3.BackColor = Color.DodgerBlue;
            gunaImageButton4.BackColor = Color.White;
            gunaImageButton5.BackColor = Color.DodgerBlue;
            gunaImageButto5.BackColor = Color.DodgerBlue;

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            
            uC_Recherche1.Visible = true;
            uC_Recherche1.BringToFront();
            
            btnRech.IdleFillColor = Color.White;
            btnRech.IdleForecolor = Color.DodgerBlue;
            btnAct.IdleFillColor = Color.DodgerBlue;
            btnAct.IdleForecolor = Color.White;
            btnOff.IdleFillColor = Color.DodgerBlue;
            btnOff.IdleForecolor = Color.White;
            btnCri.IdleFillColor = Color.DodgerBlue;
            btnCri.IdleForecolor = Color.White;
            btnCas.IdleFillColor = Color.DodgerBlue;
            btnCas.IdleForecolor = Color.White;
            btnImprimer.IdleFillColor = Color.DodgerBlue;
            btnImprimer.IdleForecolor = Color.White;
            gunaImageButton1.BackColor = Color.DodgerBlue;
            gunaImageButton2.BackColor = Color.DodgerBlue;
            gunaImageButton3.BackColor = Color.DodgerBlue;
            gunaImageButton4.BackColor = Color.DodgerBlue;
            gunaImageButton5.BackColor = Color.White;
            gunaImageButto5.BackColor = Color.DodgerBlue;


        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            ask a = new ask();
            a.ShowDialog();
            }

        private void uC_Acceuil1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_Officiers1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Criminel1_Load_1(object sender, EventArgs e)
        {

        }

        private void uC_Crime1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Recherche1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            


        }

        private void gunaImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {

            plaintes1.Visible = true;
            plaintes1.BringToFront();

            btnImprimer.IdleFillColor = Color.White;
            btnImprimer.IdleForecolor = Color.DodgerBlue;
            btnAct.IdleFillColor = Color.DodgerBlue;
            btnAct.IdleForecolor = Color.White;
            btnOff.IdleFillColor = Color.DodgerBlue;
            btnOff.IdleForecolor = Color.White;
            btnCri.IdleFillColor = Color.DodgerBlue;
            btnCri.IdleForecolor = Color.White;
            btnCas.IdleFillColor = Color.DodgerBlue;
            btnCas.IdleForecolor = Color.White;
            btnRech.IdleFillColor = Color.DodgerBlue;
            btnRech.IdleForecolor = Color.White;
            gunaImageButton1.BackColor = Color.DodgerBlue;
            gunaImageButton2.BackColor = Color.DodgerBlue;
            gunaImageButton3.BackColor = Color.DodgerBlue;
            gunaImageButton4.BackColor = Color.DodgerBlue;
            gunaImageButton5.BackColor = Color.DodgerBlue;
            gunaImageButto5.BackColor = Color.White;
        }
    }
}
