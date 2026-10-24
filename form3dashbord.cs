using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cmzz
{
    public partial class form3dashbord : Form
    {
        public form3dashbord()
        {
            InitializeComponent();

            mainpanel.Controls.Clear();

            Dashbord dashboardControl = new Dashbord();

            dashboardControl.Dock = DockStyle.Fill;

            mainpanel.Controls.Add(dashboardControl);

            dashboardControl.BringToFront();
        }

        private void btndash_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();

            Dashbord dashboardControl = new Dashbord();

            dashboardControl.Dock = DockStyle.Fill;

            mainpanel.Controls.Add(dashboardControl);

            dashboardControl.BringToFront();
        }

        private void btnexpense_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();

            addexpense expensesControl = new addexpense();

            expensesControl.Dock = DockStyle.Fill;

            mainpanel.Controls.Add(expensesControl);

            expensesControl.BringToFront();
        }

        private void btnincome_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();

            addincome incomesControl = new addincome();

            incomesControl.Dock = DockStyle.Fill;

            mainpanel.Controls.Add(incomesControl);

            incomesControl.BringToFront();
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();

            category categoryControl = new category();

            categoryControl.Dock = DockStyle.Fill;

            mainpanel.Controls.Add(categoryControl);

            categoryControl.BringToFront();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();

            _5reports categoryControl = new _5reports();

            categoryControl.Dock = DockStyle.Fill;

            mainpanel.Controls.Add(categoryControl);

            categoryControl.BringToFront();
        }
    }
}
