using System;
using System.Windows.Forms;

namespace TelefonskiImenik
{
    public partial class AddContactForm : Form
    {
        public string ContactName { get; set; } = "";
        public string ContactNumber { get; set; } = "";

        public AddContactForm()
        {
            InitializeComponent();
        }

        private void btnShrani_Click(object sender, EventArgs e)
        {
            this.ContactName = txtNaziv.Text.Trim();
            this.ContactNumber = txtStevilka.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
