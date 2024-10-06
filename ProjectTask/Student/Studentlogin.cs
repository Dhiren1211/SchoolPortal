using Mono.Unix.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectTask
{
    public partial class Studentlogin : Form
    {
        public string UID { get; set; }
        public string Pass { get; set; } 
        public Studentlogin()
        {
            InitializeComponent();
            
        }
        
        private void Studentlogin_Load(object sender, EventArgs e)
        {

        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            UID = textBox1.Text;
            Pass = textBox2.Text;
            if (UID == "Admin" && Pass == "AdminPassword")
            {
                this.Hide();
                AdminDashBoard New = new AdminDashBoard();
                New.Show();
            }
            else
            {
                if(UID =="" || Pass == "")
                {
                    MessageBox.Show("Please Enter your details properly");
                }
                else
                {
                    string constring = "Data Source=DESKTOP-DHIREN\\SQLEXPRESS;Initial Catalog=OnlineTeachingPortal;Integrated Security=True";
                    string query = "SELECT COUNT(*) FROM StudentSignup WHERE UserId = @value1 AND StdPassword = @value2";
                    int count = 0;

                    try
                    {
                        using (SqlConnection con = new SqlConnection(constring))
                        {
                            con.Open();
                            using (SqlCommand command = new SqlCommand(query, con))
                            {
                                command.Parameters.AddWithValue("@value1", UID);
                                command.Parameters.AddWithValue("@value2", Pass);
                                count = (int)command.ExecuteScalar();
                            }
                        }

                        if (count > 0)
                        {
                            // Successful login
                            MessageBox.Show("Login Successful!");
                            this.Hide();
                            StudentDashBoard New = new StudentDashBoard();
                            New.Show();
                            textBox1.Text = "";
                            textBox2.Text = "";

                           
                        }
                        else
                        {
                            // Failed login
                            MessageBox.Show("Invalid UserID or password. Please try again.");
                        }

                    }

                    catch (Exception ex)
                    {
                        // Handle the exception here
                        MessageBox.Show("An error occurred while executing the login query: " + ex.Message);
                    }
                }
            }
            
        }
        internal class AdminDashboard : AdminDashBoard { }
        internal class Signup : StudentSignup{ }
        internal class Dashboard : StudentDashBoard { }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            StudentSignup New = new StudentSignup();
            New.Show();
        }
      
    }
}
