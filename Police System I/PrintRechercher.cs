using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_System_I
{
    public partial class PrintRechercher : Form
    {
        public String Date, Prenom, nom, ville,taille,typeCrime;

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.SetToolTip(gunaPictureBox1, "print");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bm, 0, 0);
        }
        Bitmap bm;

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bm = new Bitmap(this.Size.Width,this.Size.Height, g);
            Graphics g2 = Graphics.FromImage(bm);
            g2.CopyFromScreen(this.Location.X, this.Location.Y, 100, 100, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        public int numOff;
        public Image img= null;

        public PrintRechercher()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("M/d/yyyy");
        }
        private void print(Panel pnl)
        {
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dateLbl.Text = Date;
            gunaPictureBox1.Image = img;
            lblNom.Text = nom;
            lblPrenom.Text = Prenom;
            lblTaille.Text = taille;
            lblType.Text = typeCrime;
            lblVille.Text = ville;
            NumOff.Text = numOff.ToString();
        }
    }
}
