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
    public partial class SuccesForm : Form
    {
        public SuccesForm()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            Accueil ac = new Accueil();
            this.Hide();
            ac.ShowDialog();
        }
    }
}
