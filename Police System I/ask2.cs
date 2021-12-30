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
    public partial class ask2 : Form
    {
        public ask2()
        {
            InitializeComponent();
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)

        {
            
            Form1 f = new Form1();
            Accueil a = new Accueil();
            a.Close();
            Accueil2 a2 = new Accueil2();
            a2.Close();
            this.Hide();
            f.ShowDialog();
            

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ask2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
