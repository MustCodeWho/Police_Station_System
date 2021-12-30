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
    public partial class UC_Criminel : UserControl
    {
        public UC_Criminel()
        {
            InitializeComponent();
            Affiche_data_in_Grid();
        }
        SqlConnection conn = new SqlConnection("Data source=LAPTOP-ESG5QTJF\\SQLEXPRESSE ; initial catalog=PoliceSystem; integrated security=true");
        public void ClearItems()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtAge.Text = "";
            txtAdress.Text = "";
            txtTaille.Text = "";
            txtNmbrCrime.Text = "";
            txtVille.Text = "";

        }
        private void Affiche_data_in_Grid()
        {
            conn.Open();

            String s = "select * from criminel";
            SqlDataAdapter da = new SqlDataAdapter(s, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            var dt = new DataSet();
            da.Fill(dt);
            DataGridViewCriminel.DataSource = dt.Tables[0];
            conn.Close();

        }
        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        
        int ID;
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            

        }

        private void btnMiseajour_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || txtPrenom.Text == "" || txtAge.Text == "" || txtAdress.Text == "" || txtTaille.Text == "" || txtVille.Text == "" || txtNmbrCrime.Text == "")
            {
                MessageBox.Show("Erreur ! Missing Information!");
            }
            else
            {
                try
                {
                    SqlCommand cmd2 = new SqlCommand("update criminel set nomCriminel=@nomCri,preCriminel=@preCri,ageCriminel=@ageCri,tailleCriminel=@tailleCri,villeCriminel=@villeCri,adressCriminel=@adressCri,nomPrecCrime=@numCrime where numCriminel=@numCri", conn);
                    cmd2.Parameters.AddWithValue("numCri", ID);
                    cmd2.Parameters.AddWithValue("nomCri", txtNom.Text);
                    cmd2.Parameters.AddWithValue("preCri", txtPrenom.Text);
                    cmd2.Parameters.AddWithValue("ageCri", txtAge.Text);
                    cmd2.Parameters.AddWithValue("tailleCri", txtTaille.Text);
                    cmd2.Parameters.AddWithValue("villeCri", txtVille.Text);
                    cmd2.Parameters.AddWithValue("adressCri", txtAdress.Text);
                    cmd2.Parameters.AddWithValue("numCrime", txtNmbrCrime.Text);
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Criminel " + txtNom.Text + " est bien Modifié...");
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

        private void txtClear_Click(object sender, EventArgs e)
        {
            ClearItems();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Selectioner un Criminel !!");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("delete from criminel where numCriminel=@numCri", conn);
                    cmd2.Parameters.AddWithValue("numCri", ID);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Criminel " + txtNom.Text + " est bien Supprimer...");
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || txtPrenom.Text == "" || txtAge.Text == "" || txtAdress.Text == "" || txtTaille.Text == "" || txtVille.Text == "" || txtNmbrCrime.Text == "")
            {
                MessageBox.Show("Erreur ! Missing Information!");
            }
            else
            {
                try
                {

                    SqlCommand cmd2 = new SqlCommand("insert into criminel (nomCriminel,preCriminel,ageCriminel,tailleCriminel,villeCriminel,adressCriminel,nomPrecCrime) values (@nomCri,@preCri,@ageCri,@tailleCri,@villeCri,@adressCri,@numPreCri)", conn);
                    cmd2.Parameters.AddWithValue("nomCri", txtNom.Text);
                    cmd2.Parameters.AddWithValue("preCri", txtPrenom.Text);
                    cmd2.Parameters.AddWithValue("ageCri", txtAge.Text);
                    cmd2.Parameters.AddWithValue("tailleCri", txtTaille.Text);
                    cmd2.Parameters.AddWithValue("villeCri", txtVille.Text);
                    cmd2.Parameters.AddWithValue("adressCri", txtAdress.Text);
                    cmd2.Parameters.AddWithValue("numPreCri", txtNmbrCrime.Text);
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Criminel " + txtNom.Text + " est bien Ajouter...");
                    Affiche_data_in_Grid();
                    ClearItems();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DataGridViewCriminel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(DataGridViewCriminel.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNom.Text = DataGridViewCriminel.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrenom.Text = DataGridViewCriminel.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAge.Text = DataGridViewCriminel.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTaille.Text = DataGridViewCriminel.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtVille.Text = DataGridViewCriminel.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtAdress.Text = DataGridViewCriminel.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtNmbrCrime.Text = DataGridViewCriminel.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void DataGridViewCriminel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select * from criminel where nomCriminel like @nomCri+'%'", conn);
                cmd2.Parameters.AddWithValue("nomCri", txtSearch.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd2;
                SqlCommandBuilder scb = new SqlCommandBuilder();
                var dt = new DataSet();
                da.Fill(dt);
                if (txtSearch.Text != "")
                {
                    MessageBox.Show("Criminel est Bien Trouver...");
                }
                DataGridViewCriminel.DataSource = dt.Tables[0];
                conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void UC_Criminel_Load(object sender, EventArgs e)
        {

        }
    }
}
