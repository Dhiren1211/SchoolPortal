using AForge.Video.DirectShow;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using AForge.Video;
using System.Diagnostics.Tracing;
using System.Data.SqlClient;
using System.Data;

namespace ProjectTask
{
    public partial class TeacherDashBoard : Form
    {
        private VideoCaptureDevice cameraDevice;
       
        private Bitmap screenshot;
        public TeacherDashBoard()
        {
            InitializeComponent();
         
        cameraDevice = new VideoCaptureDevice();
           
            btnMicOff.Visible= false;
        }
        private Bitmap CaptureScreen()
        {
            // Create a bitmap with the size of the screen
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            // Create a graphics object from the bitmap
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // Capture the screen and draw it onto the bitmap
                graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            }

            return bitmap;
        }
        private void ScreenShare_Click(object sender, EventArgs e)
        {
            screenshot = CaptureScreen();

            // Display the captured screen in the picture box
           pictureBox1.Image = screenshot;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        //Class Creation
        private void button6_Click(object sender, EventArgs e)
        {
            btnEnd.Visible = true;
            panel1.Visible = false;
            panel3.Visible = true;
            panelAssignment.Visible = false;
            DialogResult result = MessageBox.Show("Are you sure you want to create a class?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(result == DialogResult.Yes)
            {
                if (cameraDevice.IsRunning)
                {
                    MessageBox.Show("Camera is already open.");
                    return;
                }

                FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No camera device found.");
                    return;
                }

                cameraDevice = new VideoCaptureDevice(videoDevices[0].MonikerString);
                cameraDevice.NewFrame += CameraDevice_NewFrame;
                cameraDevice.Start();
            }
      
        }
        public void CameraDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (System.Drawing.Image)eventArgs.Frame.Clone();
        }
        //Class End
        private void btnEnd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the camera?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DialogResult R = MessageBox.Show("The class will be end!","",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if(R == DialogResult.OK)
                {
                    cameraDevice.Stop();
                    pictureBox1.Image = null;   
                   
                }
                else
                {
                    FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                    cameraDevice = new VideoCaptureDevice(videoDevices[0].MonikerString);
                    cameraDevice.NewFrame += CameraDevice_NewFrame;
                    cameraDevice.Start();
                }
               
              
            }
           
        }

        private void btnMicOn_Click(object sender, EventArgs e)
        {
            btnMicOn.Visible = false;
            btnMicOff.Visible = true;
        }

        private void btnMicOff_Click(object sender, EventArgs e)
        {
            btnMicOn.Visible = true;
            btnMicOff.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Teacherlogin New = new Teacherlogin();
            New.Show();
        }


        private void TeacherDashBoard_Load(object sender, EventArgs e)
        {
            Pnlclasscontrol.Visible = false;

            try
            {
                string constring = "Data Source=DESKTOP-DHIREN\\SQLEXPRESS;Initial Catalog=OnlineTeachingPortal;Integrated Security=True";
                string Query = "SELECT * FROM TeacherSignup WHERE UserID = @Userid AND TPassword = @password;";
                DataTable userData = new DataTable();
                using (SqlConnection conn = new SqlConnection(constring))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        Teacherlogin Login = Application.OpenForms["Teacherlogin"] as Teacherlogin;
                        string userid = Login.UId;
                        string password = Login.Pass;
                        cmd.Parameters.AddWithValue("@Userid", userid);
                        cmd.Parameters.AddWithValue("@password", password);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(userData);
                       
                     
                    }

                    if (userData.Rows.Count > 0)
                    {
                        DataRow row = userData.Rows[0];
                        string name = row["Name"].ToString();
                        string userId = row["UserId"].ToString();
                        label2.Text = "\t\tWelcome,\n"+name;
                        label4.Text = userId;
                    }
                    else
                    {
                        MessageBox.Show("Sorry, user data is not found. Please sign up first!");
                        this.Close();
                        Form2 home = new Form2();
                        home.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                this.Close();
                Form2 home = new Form2();
                home.Show();
            }
        }
        internal class form2 : Form2 { }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I apologize for the inconvenience caused. " +
                "We regret to inform you that the virtual class feature and attendance option are currently unavailable.We understand their importance and are actively working to resolve the issue. We apologize for any frustration caused and appreciate your understanding." +
                " Please feel free to reach out to our support team for further assistance. Thank you for your patience." +
                "\r\n\r\nBest regards," +
                "\r\nDhirendra kathayat" +
                "\r\nMyClassRoom");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I apologize for the inconvenience caused. " +
                "We regret to inform you that the virtual classes option is currently unavailable. Thank you for your patience." +
                "\r\n\r\nBest regards," +
                "\r\nDhirendra kathayat" +
                "\r\nMyClassRoom");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           panel3.Visible = false;
            panel1.Visible = true;
            Pnlclasscontrol.Visible = false;
            panelAssignment.Visible = true;

        }

        //BtnAssignment
        private void btnSassign_Click(object sender, EventArgs e)
        {
         


        }

        private void btnassignment_Click(object sender, EventArgs e)
        {

        }
    }
        
}

