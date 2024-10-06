using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTask.Admin
{
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Reports reports = new Reports();    
            reports.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminDashBoard dashboard = new AdminDashBoard();    
            dashboard.Show();   
        }
    }
}
