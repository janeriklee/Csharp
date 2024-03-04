using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotellipaneeli
{
    public partial class HuoneetFM : Form
    {
        private string connectionString = "Server=localhost;Database=hotellipaneeli;Uid=root;";

        public HuoneetFM()
        {
            InitializeComponent();
            NaytaHuoneet();
            TaytaHuonetyyppiComboBox();
        }

        private void HuoneetFM_Load(object sender, EventArgs e)
        {
        }

        private void PuhelinTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void TaytaHuonetyyppiComboBox()
        {
            string kysely = "SELECT Huonetyyppi FROM huone_tyypit";

            using (MySqlConnection yhteys = new MySqlConnection(connectionString))
            using (MySqlCommand komento = new MySqlCommand(kysely, yhteys))
            {
                try
                {
                    yhteys.Open();
                    using (MySqlDataReader lukija = komento.ExecuteReader())
                    {
                        while (lukija.Read())
                        {
                            string huonetyyppi = lukija.GetString("Huonetyyppi");
                            HuonetyyppiCB.Items.Add(huonetyyppi);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe haettaessa huonetyyppejä tietokannasta: " + ex.Message);
                }
            }
        }

        private void NaytaHuoneet()
        {
            string query = "SELECT HuoneenNro, Huonetyyppi, Puhelin, Vapaana FROM Huoneet";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    HallitseHuoneitaDGW.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe haettaessa huoneiden tietoja tietokannasta: " + ex.Message);
                }
            }
        }

        private void LisaaHuoneBT_Click(object sender, EventArgs e)
        {
            string huoneenNro = HuoneenNroTB.Text;
            string puhelin = PuhelinTB.Text;
            string huonetyyppi = HuonetyyppiCB.Text;
            string vapaana = VapaanaKyllaRB.Checked ? "Kyllä" : "Ei";

            if (string.IsNullOrEmpty(huoneenNro) || string.IsNullOrEmpty(puhelin) || string.IsNullOrEmpty(huonetyyppi))
            {
                MessageBox.Show("Täytä kaikki tarvittavat kentät.");
                return;
            }

            string query = "INSERT INTO Huoneet (HuoneenNro, Huonetyyppi, Puhelin, Vapaana) VALUES (@huoneenNro, @huonetyyppi, @puhelin, @vapaana)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@huoneenNro", huoneenNro);
                    command.Parameters.AddWithValue("@huonetyyppi", huonetyyppi);
                    command.Parameters.AddWithValue("@puhelin", puhelin);
                    command.Parameters.AddWithValue("@vapaana", vapaana);
                    int resultCount = command.ExecuteNonQuery();
                    if (resultCount > 0)
                    {
                        MessageBox.Show("Huone lisätty onnistuneesti!");
                        NaytaHuoneet();
                    }
                    else
                    {
                        MessageBox.Show("Huoneen lisäys epäonnistui.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe lisättäessä huonetta: " + ex.Message);
                }
            }
        }

        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            if (HallitseHuoneitaDGW.SelectedRows.Count == 0)
            {
                MessageBox.Show("Valitse rivi, jota haluat muokata.");
                return;
            }

            int selectedIndex = HallitseHuoneitaDGW.SelectedRows[0].Index;
            string selectedHuoneenNro = HallitseHuoneitaDGW.Rows[selectedIndex].Cells["HuoneenNro"].Value.ToString();

            string query = "UPDATE Huoneet SET ";

            bool muutettu = false;

            if (!string.IsNullOrEmpty(HuoneenNroTB.Text))
            {
                query += "HuoneenNro = @huoneenNro, ";
                muutettu = true;
            }
            if (!string.IsNullOrEmpty(PuhelinTB.Text))
            {
                query += "Puhelin = @puhelin, ";
                muutettu = true;
            }
            if (!string.IsNullOrEmpty(HuonetyyppiCB.Text))
            {
                query += "Huonetyyppi = @huonetyyppi, ";
                muutettu = true;
            }

            if (VapaanaKyllaRB.Checked || VapaanaEiRB.Checked)
            {
                query += "Vapaana = @vapaana ";
                muutettu = true;
            }

            query = query.TrimEnd(' ', ',');

            if (!muutettu)
            {
                MessageBox.Show("Valitse vähintään yksi kenttä, jota haluat muokata.");
                return;
            }

            query += " WHERE HuoneenNro = @selectedHuoneenNro";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    if (!string.IsNullOrEmpty(HuoneenNroTB.Text))
                    {
                        command.Parameters.AddWithValue("@huoneenNro", HuoneenNroTB.Text);
                    }
                    if (!string.IsNullOrEmpty(PuhelinTB.Text))
                    {
                        command.Parameters.AddWithValue("@puhelin", PuhelinTB.Text);
                    }
                    if (!string.IsNullOrEmpty(HuonetyyppiCB.Text))
                    {
                        command.Parameters.AddWithValue("@huonetyyppi", HuonetyyppiCB.Text);
                    }
                    if (VapaanaKyllaRB.Checked)
                    {
                        command.Parameters.AddWithValue("@vapaana", "Kyllä");
                    }
                    else if (VapaanaEiRB.Checked)
                    {
                        command.Parameters.AddWithValue("@vapaana", "Ei");
                    }
                    command.Parameters.AddWithValue("@selectedHuoneenNro", selectedHuoneenNro);

                    int resultCount = command.ExecuteNonQuery();
                    if (resultCount > 0)
                    {
                        MessageBox.Show("Huoneen tiedot päivitetty onnistuneesti!");
                        NaytaHuoneet();
                    }
                    else
                    {
                        MessageBox.Show("Huoneen tietojen päivitys epäonnistui.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe päivitettäessä huoneen tietoja: " + ex.Message);
                }
            }
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            if (HallitseHuoneitaDGW.SelectedRows.Count == 0)
            {
                MessageBox.Show("Valitse rivi, jonka haluat poistaa.");
                return;
            }

            DialogResult result = MessageBox.Show("Haluatko varmasti poistaa valitun rivin?", "Huoneen poisto", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int selectedIndex = HallitseHuoneitaDGW.SelectedRows[0].Index;

                string huoneenNro = HallitseHuoneitaDGW.Rows[selectedIndex].Cells["HuoneenNro"].Value.ToString();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Huoneet WHERE HuoneenNro = @huoneenNro";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@huoneenNro", huoneenNro);

                        int resultCount = command.ExecuteNonQuery();
                        if (resultCount > 0)
                        {
                            MessageBox.Show("Huone poistettu onnistuneesti!");
                            NaytaHuoneet();
                        }
                        else
                        {
                            MessageBox.Show("Huoneen poisto epäonnistui.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe poistettaessa huonetta: " + ex.Message);
                    }
                }
            }
        }

        private void TyhjennaSarakkeetBT_Click(object sender, EventArgs e)
        {
            HuoneenNroTB.Text = "";
            PuhelinTB.Text = "";
            HuonetyyppiCB.SelectedIndex = -1;
            VapaanaKyllaRB.Checked = false;
            VapaanaEiRB.Checked = false;
        }
    }
}
