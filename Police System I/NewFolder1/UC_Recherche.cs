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
    public partial class UC_Recherche : UserControl
    {
        public UC_Recherche()
        {
            InitializeComponent();
            getCrimes();
            ClearItems();
            Affiche_data_in_Grid();
            getOfficier();
        }
        SqlConnection conn = new SqlConnection("Data source=LAPTOP-ESG5QTJF\\SQLEXPRESSE ; initial catalog=PoliceSystem; integrated security=true");
        public void ClearItems()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTaille.Text = "";
            txtType.Text = "";
            txtVille.Text = "";
            txtNumCrime.Text = "";
            txtNumOff.Text = "";

        }
        private void Affiche_data_in_Grid()
        {
            conn.Open();
            String s = "select * from recherche";
            SqlDataAdapter da = new SqlDataAdapter(s, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            var dt = new DataSet();
            da.Fill(dt);
            DataGridViewRecherche.DataSource = dt.Tables[0];
            conn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
           

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Selectioner Le Personne Qui Rechercher !!");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("delete from recherche where numRechercher=@numRech", conn);
                    cmd2.Parameters.AddWithValue("numRech", ID);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show(txtType.Text + " est bien Supprimer...");
                    conn.Close();
                    Affiche_data_in_Grid();
                    ClearItems();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnMiseaJour_Click(object sender, EventArgs e)
        {
          
        }
      

        private void DataGridViewRecherche_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || txtPrenom.Text == "" || txtTaille.Text == "" || txtVille.Text == "")
            {
                MessageBox.Show("Erreur ! Missing Information!");
            }
            else
            {
                try
                {
                    
                    SqlCommand cmd2 = new SqlCommand("insert into recherche (nomRechercher,preRechercher,tailleRechrcher,villeRchercher,numCrime,typeCrime,numOfficier) values (@nomRech,@prenomRech,@tailleRech,@villeRech,@numCri,@typeCri,@numOff)", conn);
                    cmd2.Parameters.AddWithValue("nomRech", txtNom.Text);
                    cmd2.Parameters.AddWithValue("prenomRech", txtPrenom.Text);
                    cmd2.Parameters.AddWithValue("tailleRech", txtTaille.Text);
                    cmd2.Parameters.AddWithValue("villeRech", txtVille.Text);
                    cmd2.Parameters.AddWithValue("numCri", txtNumCrime.SelectedValue);
                    cmd2.Parameters.AddWithValue("typeCri", txtType.Text);
                    cmd2.Parameters.AddWithValue("numOff", txtNumOff.SelectedValue);
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(txtNom.Text + " est bien Ajouter...");
                    Affiche_data_in_Grid();
                    ClearItems();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            
        }
        int ID;
        private void DataGridViewRecherche_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(DataGridViewRecherche.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNom.Text = DataGridViewRecherche.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrenom.Text = DataGridViewRecherche.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTaille.Text = DataGridViewRecherche.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtVille.Text = DataGridViewRecherche.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNumCrime.SelectedValue = DataGridViewRecherche.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtType.Text = DataGridViewRecherche.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtNumOff.SelectedValue = DataGridViewRecherche.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {

            if (ID == 0)
            {
                MessageBox.Show("Selectioner Le Personne Qui Rechercher !!");
            }
            else
            {
                try
                {
                    
                    SqlCommand cmd2 = new SqlCommand("delete from recherche where numRechercher=@numRech", conn);
                    cmd2.Parameters.AddWithValue("numRech", ID);
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(txtType.Text + " est bien Supprimer...");
                    Affiche_data_in_Grid();
                    ClearItems();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void btnMiseaJour_Click_1(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || txtPrenom.Text == "" || txtTaille.Text == "" || txtVille.Text == "")
            {
                MessageBox.Show("Erreur ! Missing Information!");
            }
            else
            {
                try
                {
                    
                    SqlCommand cmd2 = new SqlCommand("update recherche set nomRechercher=@nomRech,preRechercher=@preRech,tailleRechrcher=@tailleRech,villeRchercher=@villeRech,numCrime=@numCri,typeCrime=@typeCri,numOfficier=@numOff where numRechercher=@numRech", conn);
                    cmd2.Parameters.AddWithValue("numRech", ID);
                    cmd2.Parameters.AddWithValue("nomRech", txtNom.Text);
                    cmd2.Parameters.AddWithValue("preRech", txtPrenom.Text);
                    cmd2.Parameters.AddWithValue("tailleRech", txtTaille.Text);
                    cmd2.Parameters.AddWithValue("villeRech", txtVille.Text);
                    cmd2.Parameters.AddWithValue("numCri", txtNumCrime.SelectedValue.ToString());
                    cmd2.Parameters.AddWithValue("typeCri", txtType.Text);
                    cmd2.Parameters.AddWithValue("numOff", txtNumOff.SelectedValue.ToString());
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(txtNom.Text + " est bien Modifié...");
                    
                    Affiche_data_in_Grid();
                    ClearItems();



                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            ClearItems();
        }

        private void getCrimes()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from crime", conn);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("numCrime", typeof(int));
            dt.Load(sdr);
            txtNumCrime.ValueMember = "numCrime";
            txtNumCrime.DataSource = dt;
            conn.Close();
        }

        private void getOfficier()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from officier", conn);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("numOffcier", typeof(int));
            dt.Load(sdr);
            txtNumOff.ValueMember = "numOfficier";
            txtNumOff.DataSource = dt;
            conn.Close();
        }

        private void UC_Recherche_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select * from recherche where nomRechercher like @nomRech +'%'", conn);
                cmd2.Parameters.AddWithValue("nomRech", txtSearch.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd2;
                SqlCommandBuilder scb = new SqlCommandBuilder();
                var dt = new DataSet();
                da.Fill(dt);
                if (txtSearch.Text != "")
                {
                    MessageBox.Show(txtSearch.Text + " est Bien Trouver...");
                }
                DataGridViewRecherche.DataSource = dt.Tables[0];
                conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
