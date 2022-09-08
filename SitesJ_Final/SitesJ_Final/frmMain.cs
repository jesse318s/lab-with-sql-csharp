using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SitesJ_Final
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //point to help file
            hlpInstructions.HelpNamespace = Application.StartupPath + "\\Instructions.chm";

            //connect to db
            ProgOps.OpenDatabase();
            //message stating that connection to database was succesful
            MessageBox.Show("Connection to database was successfully opened.", "Database Connection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Show();
        }

        private void mnuItemShop_Click(object sender, EventArgs e)
        {
            frmShop shop = new frmShop();

            shop.Show();
        }

        private void mnuItemHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpInstructions.HelpNamespace);
        }

        private void mnuItemAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();

            about.Show();
        }

        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            //close and dispose db
            ProgOps.CloseDatabase();
            //message stating that closing database was succesful
            MessageBox.Show("Connection to database was successfully closed.", "Database Connection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
