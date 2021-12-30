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
    public partial class UC_Acceuil : UserControl
    {
        public UC_Acceuil()
        {
            InitializeComponent();
            countOfficier();
            countCriminel();
            countCrime();
            countRecherche();
            countTypeSociaux();
            countTypeEconomique();
            countTypePolitique();
            countTypePsychologique();
        }
       SqlConnection conn = new SqlConnection("Data source=LAPTOP-ESG5QTJF\\SQLEXPRESSE ; initial catalog=PoliceSystem; integrated security=true");

        private void countOfficier()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from officier",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblOff.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void countCriminel()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from criminel", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblCri.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void countCrime()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from crime", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblCas.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void countRecherche()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from recherche", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblRech.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void countTypeSociaux()
        {
            conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from crime where typeDuCrime='"+ "Sociaux"+"'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int percentageProgress = Convert.ToInt32(dt.Rows[0][0].ToString());
            CircleProgressbar1.Value = percentageProgress;
            conn.Close();
        }
        private void countTypeEconomique()
        {
            conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from crime where typeDuCrime='"+ "Économique" + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int percentageProgress = Convert.ToInt32(dt.Rows[0][0].ToString());
            CircleProgressbar2.Value = percentageProgress;
            conn.Close();
        }
        private void countTypePolitique()
        {
            conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from crime where typeDuCrime='"+ "Politique" + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int percentageProgress = Convert.ToInt32(dt.Rows[0][0].ToString());
            CircleProgressbar3.Value = percentageProgress;
            conn.Close();

        }
        private void countTypePsychologique()
        {
            conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from crime where typeDuCrime='"+ "Psychologique" + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int percentageProgress = Convert.ToInt32(dt.Rows[0][0].ToString());
            CircleProgressbar4.Value = percentageProgress;
            conn.Close();
        }


        private void UC_Acceuil_Load(object sender, EventArgs e)
        {
          
        }

        private void PanelOff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
