using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Hotellipaneeli
{
    public partial class LoginFM : Form
    {
        private string connectionString = "Server=localhost;Database=hotellipaneeli;Uid=root;";

        public LoginFM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kayttajanimi = KayttajanimiTB.Text;
            string salasana = SalasanaTB.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Kayttajat WHERE Kayttajanimi = @kayttajanimi AND Salasana = @salasana";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kayttajanimi", kayttajanimi);
                    command.Parameters.AddWithValue("@salasana", salasana);

                    int result = Convert.ToInt32(command.ExecuteScalar());

                    if (result > 0)
                    {
                        PaneeliFM paneeliForm = new PaneeliFM();
                        paneeliForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Virheellinen käyttäjätunnus tai salasana.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe kirjautumisessa: " + ex.Message);
                }
            }
        }
    }
}