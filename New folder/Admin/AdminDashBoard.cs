using ProjectTask.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTask
{
    public partial class AdminDashBoard : Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
        }

   

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onlineTeachingPortalDataSet1.TeacherSignup' table. You can move, or remove it, as needed.
            


        }

        //Logout Button
        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 New = new Form2();
            New.Show();
        }


        //Student Management
        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Class Management
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We don't have this feature yet but we will come with it soon!!");
        }

        //Course Management
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "List of course!!";
            datagridStudent.Visible = false;
            dataGridTeacher.Visible = false;
            button7.Visible = false;
            button6.Visible = false;       
            button5.Visible = false;
        
        }


        //Teacher Management
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int totalTeacher;
           int totalStudent; 
           
            
           
            int Teacher()
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DHIREN;Initial Catalog=OnlineTeachingPortal;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT  COUNT(*) AS total_new_users FROM TeacherSignup WHERE RegisterDate >= GETDATE() OR MONTH(RegisterDate) = MONTH(GETDATE())", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string totalNewUsers = reader["total_new_users"].ToString();
                    totalTeacher = int.Parse(totalNewUsers);
                    return totalTeacher;
                }

                return 0;
            }
           
            
           
           
            int Student()
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DHIREN;Initial Catalog=OnlineTeachingPortal;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
                connection.Open();
                SqlCommand command1 = new SqlCommand("SELECT COUNT(*) AS total_new_users FROM StudentSignup WHERE RegisterDate >= GETDATE() OR MONTH(RegisterDate) = MONTH(GETDATE())", connection);
                SqlDataReader reader1 = command1.ExecuteReader();
                if (reader1.Read())
                {
                    string totalStudent1 = reader1["total_new_users"].ToString();
                    totalStudent = int.Parse(totalStudent1);
                    return totalStudent;
                }
                return 0; 
            }
          
            int totaluser = Teacher() + Student();
            MessageBox.Show("Total number of users: " + totaluser);
        }

        private void dataGridTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            Analytics analytics = new Analytics();  
            analytics.Show();
        }
    }
}
