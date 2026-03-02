using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Dashboard
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             // Get username and password from the textboxes, remove extra spaces
             string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            //Check if username or password is empty
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.");
                return; //stop the login procces/program

            }
            //Call db connection string 
            DBConnect db = new DBConnect();

            try
            {
                db.Open(); //open Database Connection
                //SQL query to count matching username and password
                string query = "SELECT COUNT(*) FROM users WHERE" +
                    " username=@username AND password=@password";


                //Create MySQL  command
                MySql.Data.MySqlClient.MySqlCommand cmd = 
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                //Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                //Execute  query and get results
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    // if 1 record found , login succesful
                    MessageBox.Show("Login Succesful");
                        //Open Dashboard
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();

                }
                else 
                {
                    //No match found
                    MessageBox.Show("nvalid Username or Password");
                }



            }
            catch (Exception ex)
            {
                //Shopw error message if something goes wrong
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close(); //CLose Database Connection
            }

        }
    }
}
