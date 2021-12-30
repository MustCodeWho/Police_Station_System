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
    public partial class officierForm : Form
    {
        public officierForm()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Accueil2 ac = new Accueil2();
            this.Hide();
            ac.ShowDialog();
        }

        private void officierForm_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.name = label2.Text + " !";
           
        }
    }
}
