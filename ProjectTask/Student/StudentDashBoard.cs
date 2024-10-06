using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using System.Linq.Expressions;
using static ProjectTask.TeacherSignup;
using System.Net;
using System.Diagnostics;

namespace ProjectTask
{
    public partial class StudentDashBoard : Form
    {
        public StudentDashBoard()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        //Loader
        private void StudentDashBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onlineTeachingPortalDataSet3.CourceList' table. You can move, or remove it, as needed.
      
            panel3.Visible = false;
            string constring = "Data Source=DESKTOP-DHIREN;Initial Catalog=OnlineTeachingPortal;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            string Query = "SELECT * FROM StudentSignup WHERE UserId=@value1 AND StdPassword=@value2";
            DataTable userData = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(Query, con))
                    {
                        Studentlogin studentLogin = Application.OpenForms["Studentlogin"] as Studentlogin;
                        if (studentLogin != null)
                        {
                            string userId = studentLogin.UID;
                            string password = studentLogin.Pass;

                            command.Parameters.AddWithValue("@value1", userId);
                            command.Parameters.AddWithValue("@value2", password);
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            adapter.Fill(userData);
                            // Use the values as needed
                            // ...
                        }
                        else
                        {
                            MessageBox.Show("User data not found. Please login again.");
                            studentLogin.Show();
                            lblUser.Text = "";
                            lblName.Text = "";
                        }
                      
                       
                    }
                }

                if (userData.Rows.Count > 0)
                {

                    // Data retrieved successfully
                    DataRow row = userData.Rows[0];
                    string name = row["Name"].ToString();
                    string contact = row["Contact"].ToString();
                    string email = row["Email"].ToString();
                    string UserId = row["UserId"].ToString();
                    // Retrieve other columns as needed
                    lblName.Text = "  "+ "Welcome,"+ "\n" + name;
                    lblUser.Text = UserId;
                }
                else
                {


                    MessageBox.Show("User date not found!!");
                    lblUser.Text = "";
                    lblName.Text = "";
                }
                
            }
            catch (Exception ex)
            {
                // Handle the exception here
                MessageBox.Show("An error occurred while retrieving user data: " + ex.Message);
                lblUser.Text = "";
                lblName.Text = "";
            }
        }

        //LogOut Button
        private void button7_Click(object sender, EventArgs e)
        {
           DialogResult = MessageBox.Show("Are you sure you want to logout","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                
                MessageBox.Show("you are logged out");
                lblUser.Text = "";
                lblName.Text = "";
                this.Close();
                Studentlogin studentLogin = Application.OpenForms["Studentlogin"] as Studentlogin;
                studentLogin.Show();
              
                
            }
            else
            {
                MessageBox.Show("Thank you for your confirmation!!");
            }
          

        }
        internal class login : Studentlogin { }


        //Profile Setting Button
        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            PanelCourse.Visible = false;
            lblconfirmpass.Visible = false; 
            lblnewpass.Visible = false;
            lbloldpass.Visible = false;
            btnpass.Visible= false;
            btnname.Visible= false;
            txtoldpass.Visible= false;
            txtnewpass.Visible= false;  
            txtconfirmpass.Visible= false;
            txtname.Visible= false;
            lbl.Visible = false;
            label11.Visible = false;
            lblemail.Visible = false;
            btnemail.Visible = false;
            txtemail.Visible = false;

        }
       
        //Exit label for Profile setting
        private void label4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }
        //Label Name change setting 
        private void lblnamechanger_Click(object sender, EventArgs e)
        {
            lblnamechanger.BackColor = Color.Coral;
            lblnamechanger.ForeColor = Color.Black;
            //Password
            lblpasschanger.BackColor = Color.WhiteSmoke;
            lblpasschanger.ForeColor = Color.MediumBlue;
            //Email
            lblemailchanger.BackColor = Color.WhiteSmoke;
            lblemailchanger.ForeColor= Color.MediumBlue;

            txtname.Visible = true;
            lbl.Visible = true;
            btnname.Visible = true;
            label11.Visible = true;
            label11.Text = "Change your name";
            //hiding textbox
            lblDefault.Visible = false;
            lblemail.Visible = false;
            btnemail.Visible = false;
            txtemail.Visible = false;
            lblconfirmpass.Visible = false;
            lblnewpass.Visible = false;
            lbloldpass.Visible = false;
            btnpass.Visible = false;
            txtoldpass.Visible = false;
            txtnewpass.Visible = false;
            txtconfirmpass.Visible = false;
            lblemail.Visible = false;
            btnemail.Visible = false;
            txtemail.Visible = false;



        }

        //Label Password change setting
        private void lblpasschanger_Click(object sender, EventArgs e)
        {
            lblnamechanger.BackColor = Color.WhiteSmoke;
            lblnamechanger.ForeColor = Color.MediumBlue;
            //Name
            lblpasschanger.BackColor = Color.Coral;
            lblpasschanger.ForeColor = Color.Black;
            //Email
            lblemailchanger.BackColor = Color.WhiteSmoke;
            lblemailchanger.ForeColor = Color.MediumBlue;

            label11.Visible = true;
            label11.Text = "Change your Password";
            lbloldpass.Visible = true;
            lblnewpass.Visible = true;
            lblconfirmpass.Visible = true;
            txtoldpass.Visible = true;
            txtnewpass .Visible = true; 
            txtconfirmpass .Visible = true; 
            label11 .Visible = true;
            btnpass .Visible = true;    
            //Hiding something 
            txtname.Visible = false;
            lbl.Visible = false;
            lblDefault.Visible = false;
            btnname.Visible = false;
            lblemail.Visible = false;
            btnemail.Visible = false;
            txtemail.Visible = false;
        }

        //label Email change setting
        private void lblemailchanger_Click(object sender, EventArgs e)
        {
            lblemailchanger.BackColor = Color.Coral;
            lblemailchanger.ForeColor = Color.Black;
            //Password
            lblpasschanger.BackColor = Color.WhiteSmoke;
            lblpasschanger.ForeColor = Color.MediumBlue;
            //Name
            lblnamechanger.BackColor = Color.WhiteSmoke;
            lblnamechanger.ForeColor = Color.MediumBlue;
            label11.Visible = true;
            label11.Text = "Change your Email";
            lblemail.Visible=true;
            btnemail .Visible=true;
            txtemail .Visible=true;
            //Hiding something
            lblDefault .Visible = false;
            lblconfirmpass.Visible=false;
            lbloldpass.Visible=false;
            lblnewpass.Visible=false;
            lbl.Visible=false;
            btnpass.Visible = false;
            txtoldpass.Visible = false;
            txtnewpass.Visible = false;
            txtconfirmpass.Visible = false;
            btnname.Visible = false;  
            txtname.Visible = false;



        }


        //Button for name change 
        private void btnname_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-DHIREN;Initial Catalog=OnlineTeachingPortal;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            string Query = "UPDATE  StudentSignup SET Name = @Value2 WHERE UserId=@value1;";
            try
            {

                using (SqlConnection conn = new SqlConnection(constring))
                {
                    string UID = lblUser.Text;
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        string name = txtname.Text; 
                        cmd.Parameters.AddWithValue ("@value2", name);
                        cmd.Parameters.AddWithValue("@value1", UID);
                        MessageBox.Show("Name is sucessfully Changed!! for User ID: "+ UID );
                        cmd.ExecuteNonQuery ();
                        lblName.Text = "Welcome, " + "\n" + name;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cant change your name ",ex.Message);
            }
        }

        //Button for password change
        private void btnpass_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-DHIREN;Initial Catalog=OnlineTeachingPortal;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            string Query = "UPDATE StudentSignup SET StdPassword = @Value2 WHERE UserId = @value1;";
            DataTable userData = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(constring))
                {
                    conn.Open();

                    // Fill userData DataTable with data
                    using (SqlCommand cmd = new SqlCommand("SELECT StdPassword FROM StudentSignup WHERE UserId = @value1", conn))
                    {
                        cmd.Parameters.AddWithValue("@value1", lblUser.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(userData);
                    }

                    if (userData.Rows.Count > 0)
                    {
                        DataRow row = userData.Rows[0];
                        string password = row["StdPassword"].ToString();

                        string pass = txtnewpass.Text;
                        string confirmpass = txtconfirmpass.Text;
                        string oldpass = txtoldpass.Text;
                        if (oldpass=="" || pass=="" || confirmpass=="")
                        {
                            if(oldpass=="")
                            {
                                MessageBox.Show("Please Enter your old password");
                            }
                            else if(pass=="")
                            {
                                MessageBox.Show("Please create your new password!!");
                            }
                            else
                            {
                                MessageBox.Show("Please Confirm your password");
                            }
                        }
                       else if (pass != confirmpass || oldpass != password)
                        {
                            if (pass != confirmpass)
                            {
                                MessageBox.Show("New password and confirm password do not match!!");
                            }
                            else if (oldpass != password)
                            {
                                MessageBox.Show("Incorrect old password");
                            }
                        }
                        else
                        {
                            using (SqlCommand updateCmd = new SqlCommand(Query, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@value2", confirmpass);
                                updateCmd.Parameters.AddWithValue("@value1", lblUser.Text);
                                updateCmd.ExecuteNonQuery();
                                MessageBox.Show("Password changed successfully");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry, can't change your password!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //For Email validation 
        internal class Valid : TeacherSignup { }
        private void btnemail_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-DHIREN;Initial Catalog=OnlineTeachingPortal;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            string Query = "UPDATE StudentSignup SET Email = @Value1 WHERE UserId = @value2;";

            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand Cmd = new SqlCommand(Query,conn))
                {
                    string Email = txtemail.Text;
                    string UserId = lblUser.Text;
                    if(EmailValidator.IsValidEmail(Email) != true)
                    {
                        MessageBox.Show("Please Enter valid EmailID!!");
                    }
                    else
                    {
                        Cmd.Parameters.AddWithValue("@value1", Email);
                        Cmd.Parameters.AddWithValue("@value2", UserId);
                        Cmd.ExecuteNonQuery();
                        MessageBox.Show("EmailId Updated sucessfully");
                    }
                   
                }
            }
        }

        //Class For student 
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We do not have this feature yet but we will come soon with it very soon!");
        }

        //Open Button for course!!
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Assuming the file path is stored in a specific column (adjust the index as needed)
                    int filePathColumnIndex = 2;
                    string filePath = selectedRow.Cells[filePathColumnIndex].Value.ToString();

                    // Open the file
                    Process.Start(filePath);
                }
                else
                {
                    MessageBox.Show("Please select a row in the DataGridView.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Download Button For course!!
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int filePathColumnIndex = 2; // Adjust this based on your DataGridView structure
                string filePath = selectedRow.Cells[filePathColumnIndex].Value.ToString();
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile(filePath, "destinationFilePath");
                }
            }
            catch(Exception ex) 
            { 
                if(dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please Select the course you want to download");
                }
                else if(dataGridView1.SelectedRows.Count>1)
                {
                    MessageBox.Show("You can Download only one course yet a time thank you!! ");
                }
                else
                {
                    MessageBox.Show("Error:", ex.Message);
                }
               
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            PanelCourse.Visible = true;
        }
    }
}
