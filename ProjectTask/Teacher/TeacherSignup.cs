using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectTask
{
    public partial class TeacherSignup : Form
    {
        public TeacherSignup()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Teacherlogin teacherlogin = new Teacherlogin();
            teacherlogin.Show();
        }
        internal class Login : Teacherlogin { }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        public class EmailValidator
        {
            public static bool IsValidEmail(string email)
            {
                // Regular expression pattern for email validation
                string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
                // Create a Regex object with the pattern
                Regex regex = new Regex(pattern);
                // Match the email against the pattern
                Match match = regex.Match(email);
                // Return true if the email is valid, false otherwise
                return match.Success;
            }
        }
        // NUmber Validator
        public class NumberValidator
        {
            public static bool IsValidNumber(string input)
            {
                foreach (char c in input)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }

                return true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Name, Password, ConfirmPassword, Email, Dob, UserId, Contact, PanNumber, Citizenshipno;

            Name = textBox3.Text;
            Password =textBox2.Text;
            ConfirmPassword = textBox1.Text;
            Dob = DateOfbirth.Text;
            UserId =textBox6.Text ;
            Contact = textBox4.Text ;
            PanNumber = textBox8.Text;
            Citizenshipno = textBox9.Text;
            Email = textBox5.Text;
            bool isValid = EmailValidator.IsValidEmail(Email);
            bool contactValid = NumberValidator.IsValidNumber(Contact);
            bool panValid = NumberValidator.IsValidNumber(PanNumber);
            bool CitizenValid = NumberValidator.IsValidNumber(Citizenshipno);
            if (Name == "" || Password == ""|| Email == "" || Dob == "" || ConfirmPassword == "" || UserId ==""|| PanNumber ==""|| Contact =="" || Citizenshipno=="")
            {
                if (Name == "")
                {
                    MessageBox.Show("Please Enter your Name");
                    Focus();
                } 
                else if (Email == "")
                {
                    MessageBox.Show("Please Enter your Email");
                    Focus();
                }
                else if (UserId == "")
                {
                    MessageBox.Show("Please Create your UserID");
                    Focus();
                }
                else if (Contact == "")
                {
                    MessageBox.Show("Please Enter your contact Number");
                    Focus();
                }
                else if (PanNumber== "")
                {
                    MessageBox.Show("Please Enter your PAN number");
                    Focus();
                }
                else if (Dob == "")
                {
                    MessageBox.Show("Please Enter your Date of Birth");
                    Focus();
                }
                
                else if (Password == "" && ConfirmPassword == "")
                {
                    MessageBox.Show("Password field can't be empty");
                    Focus();
                }                           
                else if (Citizenshipno == "")
                {
                    MessageBox.Show("Please Enter your Citizenship ID");
                    Focus();
                }           
                else
                {
                    MessageBox.Show("Please Enter your Details Properly");
                }
            }
            else
            {
                if (isValid != true)
                {
                    MessageBox.Show("Please Enter valid Email");
                   
                } 
                else if (!contactValid)
                {
                    MessageBox.Show("Please Enter Valid Number");
                } 
                else if(!panValid)
                {
                    MessageBox.Show("Please Enter valid PAN number");
                }
                else  if (Password != ConfirmPassword)
                {
                    MessageBox.Show("Password doesn't Matched");
                }
                else if(!CitizenValid)
                {
                    MessageBox.Show("Please enter valid Citizenship ID");
                }
                else if(!checkBox1.Checked)
                {
                    MessageBox.Show("You have to Accept our Terms and Conditions");
                }
                else
                {
                    try
                    {
                        string connstring = "Data Source=DESKTOP-DHIREN\\SQLEXPRESS;Initial Catalog=OnlineTeachingPortal;Integrated Security=True";
                        string Query = "INSERT INTO TeacherSignup(Name,Email,UserID,PANnumber,DateOfBirth,CitizenshipID,TPassword,Contact, RegisterDate) VALUES(@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8,@value9);";
                       using(SqlConnection conn = new SqlConnection(connstring))
                        {
                            conn.Open();
                            using(SqlCommand cmd = new SqlCommand(Query,conn))
                            {
                                cmd.Parameters.AddWithValue("@value1", Name);
                                cmd.Parameters.AddWithValue("@value2", Email);
                                cmd.Parameters.AddWithValue("@value3",UserId);
                                cmd.Parameters.AddWithValue("@value4",PanNumber);
                                cmd.Parameters.AddWithValue("@value5",Dob);
                                cmd.Parameters.AddWithValue("@value6",Citizenshipno);
                                cmd.Parameters.AddWithValue("@value7",Password);
                                cmd.Parameters.AddWithValue("@value8",Contact);
                                cmd.Parameters.AddWithValue("@value9", DateTime.Today);
                                cmd.ExecuteNonQuery();
                                //Redirect to the login form
                                MessageBox.Show("Registration Sucessful!! You are in");
                                this.Hide();
                                Teacherlogin log = new Teacherlogin();
                                log.Show();
                            }
                        }
                        
                    }
                    catch (Exception ex)
                    { 
                        MessageBox.Show("Error found:" + ex.Message, "Error" );
                    }
                   
                }

            }
           

        } 
        internal class Dashboard : TeacherDashBoard { }
      


        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Teacherlogin teacherlogin = new Teacherlogin();
            teacherlogin.Show();
        }

        private void TeacherSignup_Load(object sender, EventArgs e)
        {

        }

        // Data Base Connectivity!!

    }
}
