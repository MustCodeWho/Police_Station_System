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
using System.Drawing.Printing;

namespace Police_System_I.NewFolder1
{
    public partial class plaintes : UserControl
    {
        public plaintes()
        {
            InitializeComponent();
            getOfficier();
            Affiche_data_in_Grid();
        }

        SqlConnection conn = new SqlConnection("Data source=LAPTOP-ESG5QTJF\\SQLEXPRESSE ; initial catalog=PoliceSystem; integrated security=true");
        public void ClearItems()
        {
            txtPlaignant.Text = "";
            txtCni.Text = "";
            txtDate.Text = "";
            txtSujet.Text = "";
            numOff.Text = "";
        }
        private void Affiche_data_in_Grid()
        {
            conn.Open();

            String s = "select * from plaintes";
            SqlDataAdapter da = new SqlDataAdapter(s, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            var dt = new DataSet();
            da.Fill(dt);
            DataGridViewPP.DataSource = dt.Tables[0];
            conn.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnMiseajour_Click(object sender, EventArgs e)
        {
            if (txtSujet.Text == "" || txtCni.Text == "" || txtPlaignant.Text == "" || numOff.Text == "")
            {
                MessageBox.Show("Erreur ! Missing Information!");
            }
            else
            {
                try
                {
                    SqlCommand cmd2 = new SqlCommand("update plaintes set sujetPlainte=@sujetPl,datePlainte=@datePl,nomplaignant=@nomPl,cniplaignant=@cni,numOfficier=@numOff where numPlainte=@numPl", conn);
                    cmd2.Parameters.AddWithValue("numPl", ID);
                    cmd2.Parameters.AddWithValue("sujetPl", txtSujet.Text);
                    cmd2.Parameters.AddWithValue("datePl", txtDate.Value.Date);
                    cmd2.Parameters.AddWithValue("nomPl", txtPlaignant.Text);
                    cmd2.Parameters.AddWithValue("cni", txtCni.Text);
                    cmd2.Parameters.AddWithValue("numOff", numOff.SelectedValue);
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Plainte est bien Modifié...");
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

        private void btnSupprimer_Click(object sender, EventArgs e)
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
                    SqlCommand cmd2 = new SqlCommand("delete from plaintes where numPlainte=@numPl", conn);
                    cmd2.Parameters.AddWithValue("numPl", ID);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Plainte est bien Supprimer...");
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtSujet.Text == "" || txtCni.Text == "" || txtPlaignant.Text == "" || numOff.Text == "")
            {
                MessageBox.Show("Erreur ! Missing Information!");
            }
            else
            {
                try
                {

                    SqlCommand cmd2 = new SqlCommand("insert into plaintes (sujetPlainte,datePlainte,nomplaignant,cniplaignant,numOfficier) values (@sujetPl,@datePl,@nomPl,@cni,@numOff)", conn);
                    cmd2.Parameters.AddWithValue("sujetPl", txtSujet.Text);
                    cmd2.Parameters.AddWithValue("datePl", txtDate.Value.Date);
                    cmd2.Parameters.AddWithValue("nomPl", txtPlaignant.Text);
                    cmd2.Parameters.AddWithValue("cni", txtCni.Text);
                    cmd2.Parameters.AddWithValue("numOff", numOff.SelectedValue);
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Plainte est bien Ajouter...");
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
        int ID;
        private void DataGridViewPP_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            numOff.ValueMember = "numOfficier";
            numOff.DataSource = dt;
            conn.Close();
        }


        private void DataGridViewPP_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(DataGridViewPP.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtSujet.Text = DataGridViewPP.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDate.Text = DataGridViewPP.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPlaignant.Text = DataGridViewPP.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCni.Text = DataGridViewPP.Rows[e.RowIndex].Cells[4].Value.ToString();
            numOff.SelectedValue = DataGridViewPP.Rows[e.RowIndex].Cells[5].Value.ToString();
            label1.Text = DataGridViewPP.Rows[e.RowIndex].Cells[2].Value.ToString();
            label3.Text = DataGridViewPP.Rows[e.RowIndex].Cells[1].Value.ToString();
            label5.Text = DataGridViewPP.Rows[e.RowIndex].Cells[3].Value.ToString();
            label6.Text = DataGridViewPP.Rows[e.RowIndex].Cells[4].Value.ToString();
            label8.Text = DataGridViewPP.Rows[e.RowIndex].Cells[2].Value.ToString();
            label10.Text = DataGridViewPP.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Print(this.panel1);   
        }

        public void Print(Panel p)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = p;
            getPrintArea(p);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(print_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        public void print_PrintPage(object sender , PrintPageEventArgs e)
        {
            Rectangle pageerea = e.PageBounds;
            e.Graphics.DrawImage(bm,(pageerea.Width/2)-(this.panel1.Width/2),this.panel1.Location.Y);
        }
        Bitmap bm;
        public void getPrintArea(Panel p)
        {
            bm = new Bitmap(p.Width, p.Height);
            p.DrawToBitmap(bm, new Rectangle(0, 0, p.Width, p.Height));

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }
    }
}
