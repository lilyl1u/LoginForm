//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LoginForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }



        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LILYSLAPTOP\SQLEXPRESS02;Initial Catalog=userLogin;Integrated Security=True;TrustServerCertificate=True");


            string query = "select * from logins where username = '" + userNameTxtBox.Text.Trim() + "' and password='" + pswTxtBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                frmLoggedIn objfrmLoggedIn = new frmLoggedIn();
                this.Hide(); //hides origin login form
                objfrmLoggedIn.Show(); //show succesfully loggedin form
            }
            else
            {
                //error message
                MessageBox.Show("Please check your username and password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
