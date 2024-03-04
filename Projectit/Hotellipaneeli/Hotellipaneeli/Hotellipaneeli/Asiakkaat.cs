using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotellipaneeli
{
    public partial class AsiakasFM : Form
    {
        private string connectionString = "Server=localhost;Database=hotellipaneeli;Uid=root;";

        public AsiakasFM()
        {
            InitializeComponent();
            NaytaAsiakkaat();
        }

        private void AsiakasFM_Load(object sender, EventArgs e)
        {
        }

        private void NaytaAsiakkaat()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Asiakkaat";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    AsiakkaatDGW.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe haettaessa asiakastietoja: " + ex.Message);
                }
            }
        }

        private void LisaaUusiAsiakasBT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EtunimiAsiakasTB.Text) || string.IsNullOrWhiteSpace(SukunimiAsiakasTB.Text) ||
                string.IsNullOrWhiteSpace(LahiosoiteAsiakasTB.Text) || string.IsNullOrWhiteSpace(PostinumeroAsiakasTB.Text) ||
                string.IsNullOrWhiteSpace(KaupunkiAsiakasTB.Text))
            {
                MessageBox.Show("Täytä kaikki tiedot ennen kuin lisäät uuden asiakkaan.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Asiakkaat (Etunimi, Sukunimi, Lahiosoite, Postinumero, Postitoimipaikka) " +
                                   "VALUES (@etunimi, @sukunimi, @lahiosoite, @postinumero, @postitoimipaikka)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@etunimi", EtunimiAsiakasTB.Text);
                    command.Parameters.AddWithValue("@sukunimi", SukunimiAsiakasTB.Text);
                    command.Parameters.AddWithValue("@lahiosoite", LahiosoiteAsiakasTB.Text);
                    command.Parameters.AddWithValue("@postinumero", PostinumeroAsiakasTB.Text);
                    command.Parameters.AddWithValue("@postitoimipaikka", KaupunkiAsiakasTB.Text);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Uusi asiakas lisätty onnistuneesti!");
                    }
                    else
                    {
                        MessageBox.Show("Asiakkaan lisääminen epäonnistui.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe lisättäessä uutta asiakasta: " + ex.Message);
                }
            }
        }

        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            if (AsiakkaatDGW.SelectedRows.Count == 0)
            {
                MessageBox.Show("Valitse rivi, jonka tietoja haluat muokata.");
                return;
            }

            int selectedIndex = AsiakkaatDGW.SelectedRows[0].Index;

            if (selectedIndex >= 0)
            {
                string etunimi = AsiakkaatDGW.Rows[selectedIndex].Cells["Etunimi"].Value.ToString();
                string sukunimi = AsiakkaatDGW.Rows[selectedIndex].Cells["Sukunimi"].Value.ToString();
                string lahiosoite = AsiakkaatDGW.Rows[selectedIndex].Cells["Lahiosoite"].Value.ToString();
                string postinumero = AsiakkaatDGW.Rows[selectedIndex].Cells["Postinumero"].Value.ToString();
                string postitoimipaikka = AsiakkaatDGW.Rows[selectedIndex].Cells["Postitoimipaikka"].Value.ToString();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "UPDATE Asiakkaat SET ";

                        if (!string.IsNullOrWhiteSpace(EtunimiAsiakasTB.Text))
                        {
                            query += "Etunimi = @etunimi, ";
                        }
                        if (!string.IsNullOrWhiteSpace(SukunimiAsiakasTB.Text))
                        {
                            query += "Sukunimi = @sukunimi, ";
                        }
                        if (!string.IsNullOrWhiteSpace(LahiosoiteAsiakasTB.Text))
                        {
                            query += "Lahiosoite = @lahiosoite, ";
                        }
                        if (!string.IsNullOrWhiteSpace(PostinumeroAsiakasTB.Text))
                        {
                            query += "Postinumero = @postinumero, ";
                        }
                        if (!string.IsNullOrWhiteSpace(KaupunkiAsiakasTB.Text))
                        {
                            query += "Postitoimipaikka = @postitoimipaikka, ";
                        }

                        query = query.Remove(query.Length - 2);

                        query += " WHERE Etunimi = @oldEtunimi AND Sukunimi = @oldSukunimi";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@etunimi", EtunimiAsiakasTB.Text);
                        command.Parameters.AddWithValue("@sukunimi", SukunimiAsiakasTB.Text);
                        command.Parameters.AddWithValue("@lahiosoite", LahiosoiteAsiakasTB.Text);
                        command.Parameters.AddWithValue("@postinumero", PostinumeroAsiakasTB.Text);
                        command.Parameters.AddWithValue("@postitoimipaikka", KaupunkiAsiakasTB.Text);
                        command.Parameters.AddWithValue("@oldEtunimi", etunimi);
                        command.Parameters.AddWithValue("@oldSukunimi", sukunimi);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Asiakkaan tiedot päivitetty onnistuneesti!");
                            NaytaAsiakkaat();
                        }
                        else
                        {
                            MessageBox.Show("Asiakkaan tietojen päivitys epäonnistui.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe päivitettäessä asiakkaan tietoja: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Valitse rivi, jonka tietoja haluat muokata.");
            }
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            if (AsiakkaatDGW.SelectedRows.Count == 0)
            {
                MessageBox.Show("Valitse rivi, jonka haluat poistaa.");
                return;
            }

            DialogResult result = MessageBox.Show("Haluatko varmasti poistaa valitun rivin?", "Asiakkaan poisto", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int selectedIndex = AsiakkaatDGW.SelectedRows[0].Index;

                string etunimi = AsiakkaatDGW.Rows[selectedIndex].Cells["Etunimi"].Value.ToString();
                string sukunimi = AsiakkaatDGW.Rows[selectedIndex].Cells["Sukunimi"].Value.ToString();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Asiakkaat WHERE Etunimi = @etunimi AND Sukunimi = @sukunimi";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@etunimi", etunimi);
                        command.Parameters.AddWithValue("@sukunimi", sukunimi);

                        int resultCount = command.ExecuteNonQuery();
                        if (resultCount > 0)
                        {
                            MessageBox.Show("Asiakas poistettu onnistuneesti!");
                            NaytaAsiakkaat();
                        }
                        else
                        {
                            MessageBox.Show("Asiakkaan poisto epäonnistui.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe poistettaessa asiakasta: " + ex.Message);
                    }
                }
            }
        }

        private void TyhjennaSarakkeetAsiakasBT_Click(object sender, EventArgs e)
        {
            EtunimiAsiakasTB.Text = "";
            SukunimiAsiakasTB.Text = "";
            LahiosoiteAsiakasTB.Text = "";
            PostinumeroAsiakasTB.Text = "";
            KaupunkiAsiakasTB.Text = "";
        }
    }
}
