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
    public partial class UC_Officiers : UserControl
    {
     
        public UC_Officiers()
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
            txtTelephone.Text = "";
            txtPassword.Text = "";

        }
        private void Affiche_data_in_Grid()
        {
            conn.Open();
            
            String s = "exec AfficherAll";
            SqlDataAdapter da = new SqlDataAdapter(s,conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            var dt = new DataSet();
            da.Fill(dt);
            DataGridViewOfficier.DataSource = dt.Tables[0];
            conn.Close();
            
        }
        private void UC_Officier_Load(object sender, EventArgs e)
        {

        }


        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

     

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
          
                
         }

        private void btnMiseajour_Click(object sender, EventArgs e)
        {
            
        
            
        }

       
        int ID;
        
       
          private void DataGridViewOfficier_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
                    

          }
        

      
        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {

            if (txtNom.Text == "" || txtPrenom.Text == "" || txtAge.Text == "" || txtAdress.Text == "" || txtTelephone.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Erreur ! Missing Information!");
            }
            else
            {
                try
                {

                    SqlCommand cmd2 = new SqlCommand("exec insertIntoOff @nomOff,@preOff,@ageOff,@adressOff,@phoneOff,@passOff ", conn);
                    cmd2.Parameters.AddWithValue("nomOff", txtNom.Text);
                    cmd2.Parameters.AddWithValue("preOff", txtPrenom.Text);
                    cmd2.Parameters.AddWithValue("ageOff", txtAge.Text);
                    cmd2.Parameters.AddWithValue("adressOff", txtAdress.Text);
                    cmd2.Parameters.AddWithValue("phoneOff", txtTelephone.Text);
                    cmd2.Parameters.AddWithValue("passOff", txtPassword.Text);
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("L'Officier " + txtNom.Text + " est bien Ajouter...");
                    Affiche_data_in_Grid();
                    ClearItems();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           


        }

        private void DataGridViewOfficier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(DataGridViewOfficier.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNom.Text = DataGridViewOfficier.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrenom.Text = DataGridViewOfficier.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAge.Text = DataGridViewOfficier.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAdress.Text = DataGridViewOfficier.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTelephone.Text = DataGridViewOfficier.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPassword.Text = DataGridViewOfficier.Rows[e.RowIndex].Cells[6].Value.ToString();


        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            ClearItems();
        }

        private void btnMiseajour_Click_1(object sender, EventArgs e)
        {

            if (txtNom.Text == "" || txtPrenom.Text == "" || txtAge.Text == "" || txtAdress.Text == "" || txtTelephone.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Erreur ! Missing Information!");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("exec updateOff @numOff,@nomOff,@preOff,@ageOff,@adressOff,@phoneOff,@passOff ", conn);
                    cmd2.Parameters.AddWithValue("numOff", ID);
                    cmd2.Parameters.AddWithValue("nomOff", txtNom.Text);
                    cmd2.Parameters.AddWithValue("preOff", txtPrenom.Text);
                    cmd2.Parameters.AddWithValue("ageOff", txtAge.Text);
                    cmd2.Parameters.AddWithValue("adressOff", txtAdress.Text);
                    cmd2.Parameters.AddWithValue("phoneOff", txtTelephone.Text);
                    cmd2.Parameters.AddWithValue("passOff", txtPassword.Text);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("L'Officier " + txtNom.Text + " est bien Modifié...");
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

        private void bunifuThinButton21_Click_2(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Selectioner un Officier !!");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("exec deleteOff @numOff", conn);
                    cmd2.Parameters.AddWithValue("numOff", ID);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("L'Officier " + txtNom.Text + " est bien Supprimer...");
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

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select * from officier where nomOfficier like @nomOff + '%'", conn);
                cmd2.Parameters.AddWithValue("nomOff", txtSearch.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd2;
                SqlCommandBuilder scb = new SqlCommandBuilder();
                var dt = new DataSet();
                da.Fill(dt);
                if (txtSearch.Text != "")
                {
                    MessageBox.Show("L'Officier est Bien Trouver...");
                }
                DataGridViewOfficier.DataSource = dt.Tables[0];
                conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
