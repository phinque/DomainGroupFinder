using System;
using System.Windows.Forms;

namespace Domain_Group_Finder
{
    public partial class MainForm : Form
    {
        public MainFormController _controller;
        public MainForm()
        {
            InitializeComponent();
            _controller = new MainFormController();
            Text = "Network Group Finder";
            stsVersion.Text = string.Format("Ver. {0}", Application.ProductVersion);
            stsMessage.Text = "Ready...";
            lstDomainGroups.Items.Clear();
        }

        private void miOptionsSelectDomain_Click( object sender, EventArgs e )
        {
            _controller.SetDomainServer();
        }

        private void miOptionsExit_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void btnProcess_Click( object sender, EventArgs e )
        {
            _controller.LookupUserGroups();
        }

        private void MainForm_Load( object sender, EventArgs e )
        {
            _controller.InitializeForm( this );
        }
    }
}
