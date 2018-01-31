using System.Windows.Forms;

namespace Domain_Group_Finder
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        public string Title { set { Text = value; } }

        public string Prompt { set { lblInputPrompt.Text = value; } }

        public string InputValue { get { return txtInput.Text; } set { txtInput.Text = value; } }

        private void btnOk_Click( object sender, System.EventArgs e )
        {
           // Hide();
        }
    }
}
