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
    public partial class UC_Crime : UserControl
    {
        public UC_Crime()
        {
            InitializeComponent();
            Affiche_data_in_Grid();
            getCriminel();
            getOfficier();
            ClearItems();

        }
        SqlConnection conn = new SqlConnection("Data source=LAPTOP-ESG5QTJF\\SQLEXPRESSE ; initial catalog=PoliceSystem; integrated security=true");
        public void ClearItems()
        {
            txtNom.Text = "";
            txtLieu.Text = "";
            txtDate.Text = "";
            txtDetails.Text = "";
            txtNum.Text = "";
            txtNumCri.Text = "";
            txtNumOff.Text = "";
            txtType.Text = "";

        }
        private void Affiche_data_in_Grid()
        {
            conn.Open();

            String s = "select * from crime";
            SqlDataAdapter da = new SqlDataAdapter(s, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            var dt = new DataSet();
            da.Fill(dt);
            DataGridViewCrime.DataSource = dt.Tables[0];
            conn.Close();

        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || txtDetails.SelectedIndex == -1 || txtLieu.Text == "" || txtNum.Text == "" || txtNumCri.SelectedIndex == -1 || txtNumOff.SelectedIndex == -1 || txtType.SelectedIndex == -1)
            {
                MessageBox.Show("Erreur ! Missing Information!");
            }
            else
            {
                try
                {

                    SqlCommand cmd2 = new SqlCommand("insert into crime (lieuDuCrime,dateDuCrime,typeDuCrime,detailsCrime,numDetecDuCrime,nomDetecDuCrime,numOfficier,numCriminel) values (@lieuCri,@dateCri,@typeCri,@details,@numDetec,@nomDetec,@numOff,@numCri)", conn);
                    cmd2.Parameters.AddWithValue("lieuCri", txtLieu.Text);
                    cmd2.Parameters.AddWithValue("dateCri", txtDate.Value.Date);
                    cmd2.Parameters.AddWithValue("typeCri", txtType.SelectedItem.ToString());
                    cmd2.Parameters.AddWithValue("details", txtDetails.SelectedItem.ToString());
                    cmd2.Parameters.AddWithValue("numDetec", txtNum.Text);
                    cmd2.Parameters.AddWithValue("nomDetec", txtNom.Text);
                    cmd2.Parameters.AddWithValue("numOff", txtNumOff.SelectedValue);
                    cmd2.Parameters.AddWithValue("numCri", txtNumCri.SelectedValue);
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Crime " + txtType.Text + " est bien Ajouter...");
                    Affiche_data_in_Grid();
                    ClearItems();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnMisajour_Click(object sender, EventArgs e)
        {

        }
        int ID;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select * from crime where typeDuCrime like @typeCri +'%'", conn);
                cmd2.Parameters.AddWithValue("typeCri", txtSearch.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd2;
                SqlCommandBuilder scb = new SqlCommandBuilder();
                var dt = new DataSet();
                da.Fill(dt);
                if (txtSearch.Text != "")
                {
                    MessageBox.Show("Crime est Bien Trouver...");
                }
                DataGridViewCrime.DataSource = dt.Tables[0];
                conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void UC_Crime_Load(object sender, EventArgs e)
        {

        }

        private void DataGridViewCrime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(DataGridViewCrime.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtLieu.Text = DataGridViewCrime.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDate.Text = DataGridViewCrime.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtType.Text = DataGridViewCrime.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDetails.SelectedItem = DataGridViewCrime.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNum.Text = DataGridViewCrime.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtNom.Text = DataGridViewCrime.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtNumOff.SelectedValue = DataGridViewCrime.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtNumCri.SelectedValue= DataGridViewCrime.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void txtLieu_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            ClearItems();
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
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
                    SqlCommand cmd2 = new SqlCommand("delete from crime where numCrime=@numCri", conn);
                    cmd2.Parameters.AddWithValue("numCri", ID);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Crime " + txtType.Text + " est bien Supprimer...");
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

        private void btnMiseajour_Click(object sender, EventArgs e)
        {

            if (txtNom.Text == "" || txtDate.Text == "" || txtDetails.SelectedIndex == -1 || txtLieu.Text == "" || txtNum.Text == "" || txtNumCri.SelectedIndex == -1 || txtNumOff.SelectedIndex == -1 || txtType.SelectedIndex == -1)
            {
                MessageBox.Show("Erreur ! Missing Information!");
            }
            else
            {
                try
                {

                    SqlCommand cmd2 = new SqlCommand("update crime set lieuDuCrime=@lieuCri,dateDuCrime=@dateCri,typeDuCrime=@typeCri,detailsCrime=@details,numDetecDuCrime=@numDetec,nomDetecDuCrime=@nomDetec,numOfficier=@numOff,numCriminel=@numOff where numCrime=@numCrime", conn);
                    cmd2.Parameters.AddWithValue("numCrime", ID);
                    cmd2.Parameters.AddWithValue("lieuCri", txtLieu.Text);
                    cmd2.Parameters.AddWithValue("dateCri", txtDate.Value.Date);
                    cmd2.Parameters.AddWithValue("typeCri", txtType.Text);
                    cmd2.Parameters.AddWithValue("details", txtDetails.Text);
                    cmd2.Parameters.AddWithValue("numDetec", txtNum.Text);
                    cmd2.Parameters.AddWithValue("nomDetec", txtNom.Text);
                    cmd2.Parameters.AddWithValue("numOff", txtNumOff.SelectedValue.ToString());
                    cmd2.Parameters.AddWithValue("numCri", txtNumCri.SelectedValue.ToString());
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Crime " + txtNom.Text + " est bien Modifié...");
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

        private void getCriminel()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from criminel", conn);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("numCriminel", typeof(int));
            dt.Load(sdr);
            txtNumCri.ValueMember = "numCriminel";
            txtNumCri.DataSource = dt;
            conn.Close();
        }



        private void DataGridViewCrime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select * from crime where lieuDuCrime like @lieuCri +'%'", conn);
                cmd2.Parameters.AddWithValue("lieuCri", txtSearch.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd2;
                SqlCommandBuilder scb = new SqlCommandBuilder();
                var dt = new DataSet();
                da.Fill(dt);
                if (txtSearch.Text != "")
                {
                    MessageBox.Show("Crime est Bien Trouver...");
                }
                DataGridViewCrime.DataSource = dt.Tables[0];
                conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
