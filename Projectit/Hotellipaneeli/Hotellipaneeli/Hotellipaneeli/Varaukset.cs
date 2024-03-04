using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotellipaneeli
{
    public partial class VarauksetFM : Form
    {
        private string connectionString = "Server=localhost;Database=hotellipaneeli;Uid=root;";

        public VarauksetFM()
        {
            InitializeComponent();
            NaytaVaraukset();
            TaytaAsiakasIdComboBox();
            TaytaHuonenumeroComboBox();
        }

        private void LisaaVarausBT_Click(object sender, EventArgs e)
        {
            if (AsiakasIdCB.SelectedItem == null || HuonenumeroCB.SelectedItem == null || SisaanDP.Value == null || UlosDP.Value == null)
            {
                MessageBox.Show("Valitse kaikki tarvittavat tiedot varauksen lisäämiseksi.");
                return;
            }

            int asiakasID = (int)AsiakasIdCB.SelectedItem;
            string huonenumero = HuonenumeroCB.SelectedItem.ToString();
            DateTime sisaan = SisaanDP.Value;
            DateTime ulos = UlosDP.Value;

            string asiakkaanKokoNimi = HaekokoNimiAsiakkaalta(asiakasID);
            if (asiakkaanKokoNimi == "")
                return;

            string huonetyyppi = HaeHuonetyyppi(huonenumero);
            if (huonetyyppi == "")
                return;

            string query = "INSERT INTO Varaukset (Varaaja, Huonetyyppi, HuoneenNro, Sisaan, Ulos) VALUES (@varaaja, @huonetyyppi, @huonenumero, @sisaan, @ulos)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@varaaja", asiakkaanKokoNimi);
                    command.Parameters.AddWithValue("@huonetyyppi", huonetyyppi);
                    command.Parameters.AddWithValue("@huonenumero", huonenumero);
                    command.Parameters.AddWithValue("@sisaan", sisaan);
                    command.Parameters.AddWithValue("@ulos", ulos);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Varaus lisätty onnistuneesti!");
                            NaytaVaraukset();
                        }
                        else
                        {
                            MessageBox.Show("Varauksen lisääminen epäonnistui.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe lisätessä varausta: " + ex.Message);
                    }
                }
            }
        }

        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            if (VarauksetDGW.SelectedRows.Count == 0)
            {
                MessageBox.Show("Valitse varaus, jonka haluat muokata.");
                return;
            }

            int asiakasID = Convert.ToInt32(AsiakasIdCB.SelectedItem);
            string huonenumero = HuonenumeroCB.SelectedItem.ToString();
            DateTime sisaan = SisaanDP.Value;
            DateTime ulos = UlosDP.Value;

            string asiakkaanKokoNimi = HaekokoNimiAsiakkaalta(asiakasID);
            if (asiakkaanKokoNimi == "")
                return;

            string huonetyyppi = HaeHuonetyyppi(huonenumero);
            if (huonetyyppi == "")
                return;

            string query = "UPDATE Varaukset SET Varaaja = @varaaja, HuoneenNro = @huonenumero, Huonetyyppi = @huonetyyppi, Sisaan = @sisaan, Ulos = @ulos WHERE VarauksenID = @varauksenID";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@varaaja", asiakkaanKokoNimi);
                    command.Parameters.AddWithValue("@huonenumero", huonenumero);
                    command.Parameters.AddWithValue("@huonetyyppi", huonetyyppi);
                    command.Parameters.AddWithValue("@sisaan", sisaan);
                    command.Parameters.AddWithValue("@ulos", ulos);
                    command.Parameters.AddWithValue("@varauksenID", VarauksetDGW.SelectedRows[0].Cells["VarauksenID"].Value);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Varaus muokattu onnistuneesti!");
                            NaytaVaraukset();
                        }
                        else
                        {
                            MessageBox.Show("Varauksen muokkaaminen epäonnistui.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe muokatessa varausta: " + ex.Message);
                    }
                }
            }
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            if (VarauksetDGW.SelectedRows.Count == 0)
            {
                MessageBox.Show("Valitse varaus, jonka haluat poistaa.");
                return;
            }

            int varauksenID = Convert.ToInt32(VarauksetDGW.SelectedRows[0].Cells["VarauksenID"].Value);

            DialogResult result = MessageBox.Show("Haluatko varmasti poistaa valitun rivin?", "Varauksen poisto", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Varaukset WHERE VarauksenID = @varauksenID";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@varauksenID", varauksenID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Varaus poistettu onnistuneesti!");
                            NaytaVaraukset();
                        }
                        else
                        {
                            MessageBox.Show("Varauksen poisto epäonnistui.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe poistettaessa varausta: " + ex.Message);
                    }
                }
            }
        }

        private void TyhjennaSarakkeetBT_Click(object sender, EventArgs e)
        {
            AsiakasIdCB.SelectedIndex = -1;
            HuonenumeroCB.SelectedIndex = -1;
            SisaanDP.Value = DateTime.Today;
            UlosDP.Value = DateTime.Today;
        }

        private void NaytaVaraukset()
        {
            string query = "SELECT * FROM Varaukset";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        VarauksetDGW.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe haettaessa varauksia tietokannasta: " + ex.Message);
                    }
                }
            }
        }

        private void TaytaAsiakasIdComboBox()
        {
            string query = "SELECT AsiakasID FROM Asiakkaat";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int asiakasID = reader.GetInt32("AsiakasID");
                                AsiakasIdCB.Items.Add(asiakasID);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe haettaessa asiakas-ID:tä tietokannasta: " + ex.Message);
                    }
                }
            }
        }

        private void TaytaHuonenumeroComboBox()
        {
            string query = "SELECT HuoneenNro FROM Huoneet";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int huonenumero = reader.GetInt32("HuoneenNro");
                                HuonenumeroCB.Items.Add(huonenumero);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe haettaessa huonenumerot tietokannasta: " + ex.Message);
                    }
                }
            }
        }

        private string HaekokoNimiAsiakkaalta(int asiakasID)
        {
            string query = "SELECT CONCAT(Etunimi, ' ', Sukunimi) AS Kokonimi FROM Asiakkaat WHERE AsiakasID = @asiakasID";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@asiakasID", asiakasID);
                    try
                    {
                        connection.Open();
                        return command.ExecuteScalar()?.ToString() ?? "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe haettaessa asiakkaan nimeä: " + ex.Message);
                        return "";
                    }
                }
            }
        }

        private string HaeHuonetyyppi(string huonenumero)
        {
            string query = "SELECT Huonetyyppi FROM Huoneet WHERE HuoneenNro = @huonenumero";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@huonenumero", huonenumero);
                    try
                    {
                        connection.Open();
                        return command.ExecuteScalar()?.ToString() ?? "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe haettaessa huonetyyppiä: " + ex.Message);
                        return "";
                    }
                }
            }
        }
    }
}