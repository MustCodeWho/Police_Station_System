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
namespace Police_System_I
{
    public partial class Form1 : Form
    {
        public String name;

        public Form1()
        {
            InitializeComponent();      

        }
        SqlConnection conn = new SqlConnection("Data source=LAPTOP-ESG5QTJF\\SQLEXPRESSE ; initial catalog=PoliceSystem; integrated security=true");

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (combo.Text == "Admin")
            {
                if (txtName.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Vous avez oublie d'ecrire votre nom ou votre mot de passe!");
                }
                else 
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from admintbl where username='" + txtName.Text + "' and pass='" + txtPass.Text + "'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        SuccesForm sf = new SuccesForm();
                        sf.ShowDialog();
                    }
                    else
                    {
                            MessageBox.Show("Erreur dans le mot de passe ou username!");
                    }
                    conn.Close();
                }
                
            }
            else if(combo.Text == "Officier")
            {
                if (txtName.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Vous avez oublie d'ecrire votre nom ou votre mot de passe!");
                }
                else
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from officier where nomOfficier='" + txtName.Text + "' and passOfficier='" + txtPass.Text + "'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        officierForm of = new officierForm();
                        of.ShowDialog();
                        name = txtName.Text;
                    }
                    else 
                    {

                        MessageBox.Show("Erreur dans le mot de passe ou username!");
                    }

                    conn.Close();
                }

            }
            else
            {
                MessageBox.Show("Select un Utilisateur!!");
            }

           
        }
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Nom d'Utilisateur")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.FromArgb(179, 127, 231);
                Font f = new Font("Century Gothic",14,FontStyle.Regular);
                txtName.Font = f;

            }

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Nom d'Utilisateur";
                txtName.ForeColor = Color.SlateGray;
                
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Mot de passe")
            {
                txtPass.Text = "";
                txtPass.PasswordChar = '*';
                txtPass.UseSystemPasswordChar = false;
                txtPass.ForeColor = Color.FromArgb(179, 127, 231);
                Font f3 = new Font("Century Gothic", 13, FontStyle.Regular);
                txtName.Font = f3;

            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Mot de passe";
                txtPass.UseSystemPasswordChar = true;
                txtPass.ForeColor = Color.SlateGray;

                



            }
        }


        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo.Text = "--Sélectionnez un Utilisateur--";
            Font f3 = new Font("Century Gothic", 13, FontStyle.Regular);
            txtName.Font = f3;


        }

        private void combo_Enter(object sender, EventArgs e)
        {

            combo.Text = "--Sélectionnez un Utilisateur--";
            Font f3 = new Font("Century Gothic", 13, FontStyle.Regular);
            txtName.Font = f3;
        }

      
        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (CheckOn.Checked == true)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtPass_TextChanged(object sender, EventArgs e)
        {


        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {


        }


    }
}
