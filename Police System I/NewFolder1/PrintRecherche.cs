using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Police_System_I.NewFolder1
{
    public partial class PrintRecherche : UserControl
    {
        public PrintRecherche()
        {
            InitializeComponent();
           
            getOfficier();
            getPrenom();
            getNom();
            getTaille();
            getVille();
            getTypeCrime();
        
            }

        SqlConnection conn = new SqlConnection("Data source=LAPTOP-ESG5QTJF\\SQLEXPRESSE ; initial catalog=PoliceSystem; integrated security=true");


        private void Upload_image()
        {
         
            try
            {
                openFileDialog1.Filter = "image files| *.jpg; *.png; *.gif";
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(openFileDialog1.FileName);

                }
            }

            catch(Exception ex)
            {
                
                MessageBox.Show("Error dans l'image ! \n " +ex.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
                }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Upload_image();
        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            comboBox1.Text = "";
            comboNom.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            txtType.Text = "";
            txtNumOff.Text = "";
          
        }

        private void PrintRecherche_Load(object sender, EventArgs e)
        {
            clear();
        }
        

        private void getOfficier()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from recherche", conn);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("numRechercher", typeof(int));
            dt.Load(sdr);
            txtNumOff.ValueMember = "numRechercher";
            txtNumOff.DataSource = dt;
            conn.Close();
        }

        private void getPrenom()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from recherche", conn);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("preRechercher", typeof(String));
            dt.Load(sdr);
            comboBox1.ValueMember = "preRechercher";
            comboBox1.DataSource = dt;
            conn.Close();

        }

        private void getNom()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from recherche", conn);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("nomRechercher", typeof(String));
            dt.Load(sdr);
            comboNom.ValueMember = "nomRechercher";
            comboNom.DataSource = dt;
            conn.Close();

        }

        private void getVille()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from recherche", conn);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("villeRchercher", typeof(String));
            dt.Load(sdr);
            comboBox4.ValueMember = "villeRchercher";
            comboBox4.DataSource = dt;
            conn.Close();
        }


        private void getTaille()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from recherche", conn);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("tailleRechrcher", typeof(String));
            dt.Load(sdr);
            comboBox3.ValueMember = "tailleRechrcher";
            comboBox3.DataSource = dt;
            conn.Close();
        }

        private void getTypeCrime()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from recherche", conn);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("typeCrime", typeof(String));
            dt.Load(sdr);
            txtType.ValueMember = "typeCrime";
            txtType.DataSource = dt;
            conn.Close();
        }
        

        private void btnInfo_Click(object sender, EventArgs e)
        {
            PrintRechercher rech = new PrintRechercher();
            rech.img = pictureBox.Image;
            rech.Prenom = comboBox1.Text;
            rech.nom = comboNom.SelectedValue.ToString();
            rech.taille = comboBox3.Text;
            rech.ville = comboBox4.Text;
            rech.typeCrime = txtType.Text;
            rech.numOff = Convert.ToInt32 (txtNumOff.Text.ToString());
            rech.ShowDialog();
            clear();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBox1.Text = "Rachid";
            comboBox3.Text = "1.71";
            comboBox4.Text = "Safi";
            txtType.Text = "Politique";
            txtNumOff.Text = "1";
       
            }

        private void txtNumOff_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtType_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
