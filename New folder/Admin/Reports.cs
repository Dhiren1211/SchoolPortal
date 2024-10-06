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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btnbackward_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminDashBoard Dashboard = new AdminDashBoard();
            Dashboard.Show();
        }

        private void btnforward_Click(object sender, EventArgs e)
        {
            this.Close();
            Analytics analytics = new Analytics();
            analytics.Show();
        }
    }
}
