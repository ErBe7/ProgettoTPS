using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace ProgettoTPS
{
    public partial class TeamPlayersStats : Form
    {
        private DataTable playersTable;
        private DataTable filteredPlayersTable; // Store the original filtered data
        private string teamName;

        public TeamPlayersStats(string teamAbbreviation, string teamName)
        {
            InitializeComponent();
            LoadPlayers(teamAbbreviation,teamName);
            LoadTeamImage(teamAbbreviation);
            this.teamName = teamName;
        }

        private void LoadPlayers(string teamAbbreviazione,string teamName)
        {
            // Imposta il percorso del file CSV per i giocatori
            string playersFilePath = "C:\\Users\\besom\\Desktop\\ProgettoTPS\\assets\\Tables\\players.csv";

            if (File.Exists(playersFilePath))
            {
                // Leggi i giocatori dal file CSV
                playersTable = ReadCSV(playersFilePath);

                // Filtra i giocatori per la squadra selezionata
                DataView dv = playersTable.DefaultView;
                dv.RowFilter = $"teamAbbreviation = '{teamAbbreviazione}'";
                filteredPlayersTable = dv.ToTable(); // Store the original filtered data

                if (filteredPlayersTable.Rows.Count > 0)
                {
                    // Mostra i giocatori nel DataGridView
                    dataGridView1.DataSource = filteredPlayersTable; // Assicurati che dataGridViewPlayers sia un oggetto di tipo DataGridView

                    // Aggiorna il testo del label con il nome della squadra selezionata
                    label1.Text = $"Giocatori della squadra {teamName}";
                }
                else
                {
                    MessageBox.Show("Nessun giocatore trovato per la squadra selezionata.");
                }
            }
            else
            {
                MessageBox.Show("Il file CSV dei giocatori non esiste.");
            }
        }


        private void LoadTeamImage(string teamAbbreviazione)
        {
            // Imposta il percorso dell'immagine della squadra
            string imagePath = $"C:\\Users\\besom\\Desktop\\ProgettoTPS\\assets\\SquadreNBA\\{teamAbbreviazione}.png";

            if (File.Exists(imagePath))
            {
                teamPictureBox1.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("L'immagine della squadra non esiste.");
            }
        }

        private DataTable ReadCSV(string filePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(filePath))
            {
                // Leggi la prima riga per ottenere i nomi delle colonne
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }

                // Leggi il resto delle righe
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    if (rows.Length != headers.Length)
                    {
                        // Skip or handle rows with unexpected number of columns
                        continue;
                    }
                    DataRow dataRow = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dataRow[i] = rows[i];
                    }
                    dt.Rows.Add(dataRow);
                }
            }
            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Controlla se è stata cliccata una cella contenente il nome del giocatore
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells["Player"].Value != null)
                {
                    // Ottieni il nome del giocatore dalla cella cliccata
                    string playerName = row.Cells["Player"].Value.ToString();

                    // Apri il browser predefinito del sistema con il sito desiderato (sostituisci con il tuo URL)
                    string url = "https://it.wikipedia.org/wiki/" + playerName;
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else
                {
                    MessageBox.Show("La cella selezionata non contiene un nome valido.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filteredPlayersTable != null && filteredPlayersTable.Rows.Count > 0)
            {
                // Clone the original filtered table to ensure we always sort from the original set
                DataTable sortedTable = filteredPlayersTable.Clone();
                sortedTable.Columns["GP"].DataType = typeof(int);

                // Import rows from filteredPlayersTable, converting "GP" to integer
                foreach (DataRow row in filteredPlayersTable.Rows)
                {
                    DataRow newRow = sortedTable.NewRow();
                    newRow.ItemArray = row.ItemArray;
                    newRow["GP"] = Convert.ToInt32(row["GP"]);
                    sortedTable.Rows.Add(newRow);
                }

                // Sort the players by GP (games played) in descending order
                DataView dv = sortedTable.DefaultView;
                dv.Sort = "GP ASC";

                // Take the top 5 players
                DataTable top5PlayersTable = dv.ToTable().AsEnumerable().Take(5).CopyToDataTable();

                // Show the top 5 players in the DataGridView
                dataGridView1.DataSource = top5PlayersTable;
            }
            else
            {
                MessageBox.Show("Nessun giocatore trovato per la squadra selezionata.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filteredPlayersTable != null && filteredPlayersTable.Rows.Count > 0)
            {
                // Clone the original filtered table to ensure we always sort from the original set
                DataTable sortedTable = filteredPlayersTable.Clone();
                sortedTable.Columns["GP"].DataType = typeof(int);

                // Import rows from filteredPlayersTable, converting "GP" to integer
                foreach (DataRow row in filteredPlayersTable.Rows)
                {
                    DataRow newRow = sortedTable.NewRow();
                    newRow.ItemArray = row.ItemArray;
                    newRow["GP"] = Convert.ToInt32(row["GP"]);
                    sortedTable.Rows.Add(newRow);
                }

                // Sort the players by GP (games played) in descending order
                DataView dv = sortedTable.DefaultView;
                dv.Sort = "GP DESC";

                // Take the top 5 players
                DataTable top5PlayersTable = dv.ToTable().AsEnumerable().Take(5).CopyToDataTable();

                // Show the top 5 players in the DataGridView
                dataGridView1.DataSource = top5PlayersTable;
            }
            else
            {
                MessageBox.Show("Nessun giocatore trovato per la squadra selezionata.");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Reset to the original filtered players
            if (filteredPlayersTable != null)
            {
                dataGridView1.DataSource = filteredPlayersTable;
                MessageBox.Show("La tabella è stata ripristinata al suo stato originale.");
            }
            else
            {
                MessageBox.Show("Non ci sono dati da resettare.");
            }
        }
    }
}
