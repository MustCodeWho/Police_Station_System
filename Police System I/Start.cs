using System;
using System.Drawing;
using System.Windows.Forms;

namespace Police_System_I
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            
            {
                progressBar1.Value += 1;
                label1.Text = progressBar1.Value.ToString() + "%";


            }
            else
            {
                timer1.Stop();
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();

            }
        }
        private void Start_Load(object sender, EventArgs e)
        {    
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_progressChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
