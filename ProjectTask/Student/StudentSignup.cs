using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectTask.TeacherSignup;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace ProjectTask
{
    public partial class StudentSignup : Form
    {
        public StudentSignup()
        {
            InitializeComponent();
        }

       
       

        private void StudentSignup_Load(object sender, EventArgs e)
        {

        }

        internal class Valid : TeacherSignup { }
        internal class Dashboard : StudentDashBoard { }
        internal class Login : Studentlogin { }
     

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            Valid valid = new Valid();
            string name, password, confirmpassword, Dob, CitizenshipID, Email, userId, Contact, level;
            name = textBox3.Text;
            password = textBox2.Text;
            confirmpassword = textBox1.Text;
            Dob = dateofbirth.Text;
            CitizenshipID = textBox8.Text;
            Email = textBox7.Text;
            userId = textBox5.Text;
            Contact = textBox4.Text;
            level = SelectLevel.Text;
            string today = DateTime.Today.ToString();
            if (name == "" || password == "" || confirmpassword == "" || Dob == "" || Email == "" || Contact == "" || level == "" || userId == "" || CitizenshipID == "")
            {
                MessageBox.Show("Please enter your details properly!");
                if (name == "")
                {
                    MessageBox.Show("Please enter your Name");
                }
                else if (Contact == "")
                {
                    MessageBox.Show("Please enter your contact number");
                }
                else if (userId == "")
                {
                    MessageBox.Show("Please create your userId");
                }
                else if (password == "" || confirmpassword == "")
                {
                    if (password == "")
                    {
                        MessageBox.Show("Please create your Password");
                    }
                    else
                    {
                        MessageBox.Show("Please confirm your Password");
                    }
                }
                else if (Email == "")
                {
                    MessageBox.Show("Please Enter your emial ID");
                }
                else if (CitizenshipID == "")
                {
                    MessageBox.Show("Please Enter your Citizenship ID");
                }
                else if (level == "")
                {
                    MessageBox.Show("Please Select your level");
                }


            }

            else
            {
                try
                {
                    string constring = "Data Source=DESKTOP-DHIREN;Initial Catalog=OnlineTeachingPortal;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
                    string Query1 = "SELECT COUNT(*) FROM StudentSignup WHERE UserId = @value1;";

                    using (SqlConnection con1 = new SqlConnection(constring))
                    {
                        con1.Open();
                        using (SqlCommand cmd = new SqlCommand(Query1, con1))
                        {
                            cmd.Parameters.AddWithValue("@value1", userId);
                            int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                            if (userCount > 0)
                            {
                                MessageBox.Show("User Id is already taken create new one!!");
                                userId = "";
                                textBox5.Text = "";

                            }
                            else
                            {

                                 if (!NumberValidator.IsValidNumber(Contact))
                                {
                                    MessageBox.Show("Please Enter Valid Number");
                                }
                                else if (EmailValidator.IsValidEmail(Email) != true)
                                {
                                    MessageBox.Show("Please Enter valid Email");

                                }
                                else if (password != confirmpassword)
                                {
                                    MessageBox.Show("Password doesn't Matched");
                                }
                                else if (!NumberValidator.IsValidNumber(CitizenshipID))
                                {
                                    MessageBox.Show("Please enter valid Citizenship ID");
                                }
                                else if (!checkBox1.Checked)
                                {
                                    MessageBox.Show("You have to Accept our Terms and Conditions");
                                }
                                else
                                {
                                    string query = "INSERT INTO StudentSignup(Name, Contact, UserId, StdPassword, DateOfBirth, Email, CitizenshipId, StdLevel,RegisterDate) VALUES (@value0, @value1, @value2, @value3, @value4, @value5, @value6, @value7,@value8)";

                                    try
                                    {
                                        using (SqlConnection con2 = new SqlConnection(constring))
                                        {
                                            con2.Open();
                                            using (SqlCommand command = new SqlCommand(query, con2))
                                            {
                                                command.Parameters.AddWithValue("@value0", name);
                                                command.Parameters.AddWithValue("@value1", Contact);
                                                command.Parameters.AddWithValue("@value2", userId);
                                                command.Parameters.AddWithValue("@value3", password);
                                                command.Parameters.AddWithValue("@value4", Dob);
                                                command.Parameters.AddWithValue("@value5", Email);
                                                command.Parameters.AddWithValue("@value6", CitizenshipID);
                                                command.Parameters.AddWithValue("@value7", level);
                                                command.Parameters.AddWithValue("@value8", DateTime.Today);
                                                command.ExecuteNonQuery();
                                                MessageBox.Show("Registration Successful!! You are in");
                                                this.Hide();
                                                Studentlogin login = new Studentlogin();
                                                login.Show();
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        // Handle the exception here
                                        MessageBox.Show("An error occurred while executing the INSERT query: " + ex.Message);
                                    }

                                }
                            }




                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Studentlogin studentlogin = new Studentlogin();
            studentlogin.Show();
        }
    }
}
