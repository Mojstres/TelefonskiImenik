using System;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TelefonskiImenik
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadContactsFromDatabase();
        }

        // Naloži kontakte iz baze z opcijo filtra po nazivu
        private void LoadContactsFromDatabase(string filter = "")
        {
            DataTable dt = new DataTable();
            string query = "SELECT naziv AS 'Naziv', stevilka AS 'Tel. Številka' FROM imenik";
            if (!string.IsNullOrEmpty(filter))
            {
                query += " WHERE naziv LIKE @filter";
            }

            string connString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(filter))
                    {
                        cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");
                    }
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            dgvContacts.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            LoadContactsFromDatabase(searchTerm);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (AddContactForm addForm = new AddContactForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    AddContactToDatabase(addForm.ContactName, addForm.ContactNumber);
                    LoadContactsFromDatabase();
                }
            }
        }

        private void AddContactToDatabase(string naziv, string stevilka)
        {
            string query = "INSERT INTO imenik (naziv, stevilka) VALUES (@naziv, @stevilka)";
            string connString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@naziv", naziv);
                    cmd.Parameters.AddWithValue("@stevilka", stevilka);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
