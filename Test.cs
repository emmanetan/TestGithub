using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGithub
{
    public partial class Test: Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Loadform(new Product());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Loadform(new User());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Loadform(new Report());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
