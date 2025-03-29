using System;
using System.Windows.Forms;

namespace TelefonskiImenik
{
    public partial class MainForm : Form
    {
        private Label lblKontakt;
        private Button btnDodaj;

        public MainForm()
        {
            lblKontakt = new Label { Left = 20, Top = 20, Width = 300 };
            btnDodaj = new Button { Text = "Dodaj", Left = 20, Top = 60, Width = 100 };
            btnDodaj.Click += btnDodaj_Click;

            this.Controls.Add(lblKontakt);
            this.Controls.Add(btnDodaj);
            this.Text = "Telefonski imenik";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnDodaj_Click(object? sender, EventArgs e)
        {
            using (AddContactForm addContactForm = new AddContactForm())
            {
                if (addContactForm.ShowDialog() == DialogResult.OK)
                {
                    lblKontakt.Text = $"Ime: {addContactForm.ContactName}, Tel: {addContactForm.ContactNumber}";
                }
            }
        }
    }

    public partial class AddContactForm : Form
    {
        public string ContactName { get; private set; } = string.Empty;
        public string ContactNumber { get; private set; } = string.Empty;

        private TextBox txtIme;
        private TextBox txtTelefon;
        private Button btnShrani;
        private Label lblIme;
        private Label lblTelefon;

        public AddContactForm()
        {
            // Ime
            lblIme = new Label { Text = "Ime", Left = 20, Top = 20, Width = 200 };

            // Telefonska številka
            lblTelefon = new Label { Text = "Tel. Številka", Left = 20, Top = 80, Width = 200 };

            // Vnosno polje za Ime
            txtIme = new TextBox { Left = 20, Top = 40, Width = 200 };

            // Vnosno polje za Telefonsko številko
            txtTelefon = new TextBox { Left = 20, Top = 100, Width = 200 };

            // Shrani gumb
            btnShrani = new Button { Text = "Shrani", Left = 20, Top = 140, Width = 200 };
            btnShrani.Click += BtnShrani_Click;

            this.Controls.Add(lblIme);
            this.Controls.Add(lblTelefon);
            this.Controls.Add(txtIme);
            this.Controls.Add(txtTelefon);
            this.Controls.Add(btnShrani);

            this.Text = "Dodaj Kontakt";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void BtnShrani_Click(object? sender, EventArgs e)
        {
            ContactName = txtIme.Text;
            ContactNumber = txtTelefon.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}