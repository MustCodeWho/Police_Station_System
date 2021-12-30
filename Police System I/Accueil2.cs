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
    public partial class Accueil2 : Form
    {
        public Accueil2()
        {
            InitializeComponent();
            btnAct.IdleFillColor = Color.White;
            btnAct.IdleForecolor = Color.DodgerBlue;
            gunaImageButton1.BackColor = Color.White;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            ask a = new ask();
            a.ShowDialog();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ask2 a2 = new ask2();
            a2.ShowDialog();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            uC_Acceuil1.Visible = true;
            uC_Acceuil1.BringToFront();
            btnAct.IdleFillColor = Color.White;
            btnAct.IdleForecolor = Color.DodgerBlue;
            btnCri.IdleFillColor = Color.DodgerBlue;
            btnCri.IdleForecolor = Color.White;
            btnCas.IdleFillColor = Color.DodgerBlue;
            btnCas.IdleForecolor = Color.White;
            btnRech.IdleFillColor = Color.DodgerBlue;
            btnRech.IdleForecolor = Color.White;
            btnImprimer.IdleFillColor = Color.DodgerBlue;
            btnImprimer.IdleForecolor = Color.White;
            gunaImageButton1.BackColor = Color.White;
            gunaImageButto2.BackColor = Color.DodgerBlue;
            gunaImageButto3.BackColor = Color.DodgerBlue;
            gunaImageButto4.BackColor = Color.DodgerBlue;
            gunaImageButto5.BackColor = Color.DodgerBlue;
        }

        private void btnCri_Click(object sender, EventArgs e)
        {
            uC_Criminel1.Visible = true;
            uC_Criminel1.BringToFront();
            btnCri.IdleFillColor = Color.White;
            btnCri.IdleForecolor = Color.DodgerBlue;
            btnAct.IdleFillColor = Color.DodgerBlue;
            btnAct.IdleForecolor = Color.White;
            btnCas.IdleFillColor = Color.DodgerBlue;
            btnCas.IdleForecolor = Color.White;
            btnRech.IdleFillColor = Color.DodgerBlue;
            btnRech.IdleForecolor = Color.White;
            btnImprimer.IdleFillColor = Color.DodgerBlue;
            btnImprimer.IdleForecolor = Color.White;
            gunaImageButton1.BackColor = Color.DodgerBlue;
            gunaImageButto2.BackColor = Color.White;
            gunaImageButto3.BackColor = Color.DodgerBlue;
            gunaImageButto4.BackColor = Color.DodgerBlue;
            gunaImageButto5.BackColor = Color.DodgerBlue;

        }

        private void btnCas_Click(object sender, EventArgs e)
        {
            uC_Crime1.Visible = true;
            uC_Crime1.BringToFront();
            btnCas.IdleFillColor = Color.White;
            btnCas.IdleForecolor = Color.DodgerBlue;
            btnAct.IdleFillColor = Color.DodgerBlue;
            btnAct.IdleForecolor = Color.White;
            btnCri.IdleFillColor = Color.DodgerBlue;
            btnCri.IdleForecolor = Color.White;
            btnRech.IdleFillColor = Color.DodgerBlue;
            btnRech.IdleForecolor = Color.White;
            btnImprimer.IdleFillColor = Color.DodgerBlue;
            btnImprimer.IdleForecolor = Color.White;
            gunaImageButton1.BackColor = Color.DodgerBlue;
            gunaImageButto2.BackColor = Color.DodgerBlue;
            gunaImageButto3.BackColor = Color.White;
            gunaImageButto4.BackColor = Color.DodgerBlue;
            gunaImageButto5.BackColor = Color.DodgerBlue;

        }

        private void btnRech_Click(object sender, EventArgs e)
        {
            uC_Recherche1.Visible = true;
            uC_Recherche1.BringToFront();

            btnRech.IdleFillColor = Color.White;
            btnRech.IdleForecolor = Color.DodgerBlue;
            btnAct.IdleFillColor = Color.DodgerBlue;
            btnAct.IdleForecolor = Color.White;
            btnCri.IdleFillColor = Color.DodgerBlue;
            btnCri.IdleForecolor = Color.White;
            btnCas.IdleFillColor = Color.DodgerBlue;
            btnCas.IdleForecolor = Color.White;
            btnImprimer.IdleFillColor = Color.DodgerBlue;
            btnImprimer.IdleForecolor = Color.White;
            gunaImageButton1.BackColor = Color.DodgerBlue;
            gunaImageButto2.BackColor = Color.DodgerBlue;
            gunaImageButto3.BackColor = Color.DodgerBlue;
            gunaImageButto4.BackColor = Color.White;
            gunaImageButto5.BackColor = Color.DodgerBlue;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            printRecherche1.Visible = true;
            printRecherche1.BringToFront();

            btnImprimer.IdleFillColor = Color.White;
            btnImprimer.IdleForecolor = Color.DodgerBlue;
            btnAct.IdleFillColor = Color.DodgerBlue;
            btnAct.IdleForecolor = Color.White;
            btnCri.IdleFillColor = Color.DodgerBlue;
            btnCri.IdleForecolor = Color.White;
            btnCas.IdleFillColor = Color.DodgerBlue;
            btnCas.IdleForecolor = Color.White;
            btnRech.IdleFillColor = Color.DodgerBlue;
            btnRech.IdleForecolor = Color.White;
            gunaImageButton1.BackColor = Color.DodgerBlue;
            gunaImageButto2.BackColor = Color.DodgerBlue;
            gunaImageButto3.BackColor = Color.DodgerBlue;
            gunaImageButto4.BackColor = Color.DodgerBlue;
            gunaImageButto5.BackColor = Color.White;
        }

        private void Accueil2_Load(object sender, EventArgs e)
        {

        }

        private void uC_Acceuil1_Load(object sender, EventArgs e)
        {

        }
    }
}
