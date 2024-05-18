using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace ProgettoTPS
{
    public partial class NBA_Teams : Form
    {
        private DataTable dataTable;
        private List<string> easternConferenceTeams;
        private List<string> westernConferenceTeams;

        public NBA_Teams()
        {
            InitializeComponent();
            easternConferenceTeams = new List<string>();
            westernConferenceTeams = new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\besom\\Desktop\\ProgettoTPS\\assets\\Tables\\team.csv";

            if (File.Exists(filePath))
            {
                dataTable = ReadCSV(filePath);

                // Popola le liste delle squadre delle due conference
                foreach (DataRow row in dataTable.Rows)
                {
                    string teamName = row["full_name"].ToString();
                    string conference = row["Conference"].ToString();

                    if (conference == "EAST")
                        easternConferenceTeams.Add(teamName);
                    else if (conference == "WEST")
                        westernConferenceTeams.Add(teamName);
                }

                Table.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Il file CSV non esiste.");
            }
        }

        private DataTable ReadCSV(string filePath)
        {
            DataTable dt = new DataTable();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dt.Columns.Add(header);
                    }

                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dataRow = dt.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataRow[i] = rows[i];
                        }
                        dt.Rows.Add(dataRow);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante la lettura del file CSV: " + ex.Message);
            }

            return dt;
        }

        private void easternConferenceButton_Click(object sender, EventArgs e)
        {
            FilterByConference("EAST");
        }

        private void westernConferenceButton_Click(object sender, EventArgs e)
        {
            FilterByConference("WEST");
        }

        private void FilterByConference(string conference)
        {
            DataView dv = dataTable.DefaultView;
            dv.RowFilter = $"Conference = '{conference}'";
            Table.DataSource = dv.ToTable();
        }

        private void winButton_Click(object sender, EventArgs e)
        {
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Sort the DataTable by the "W" column in descending order
                DataView dv = dataTable.DefaultView;
                dv.Sort = "W DESC";
                dataTable = dv.ToTable();

                // Re-bind the sorted DataTable to the DataGridView
                Table.DataSource = dataTable;
            }
        }

        private void lossButton_Click(Object sender, EventArgs e)
        {
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                DataView dv = dataTable.DefaultView;
                dv.Sort = "L DESC"; // Ordina in base al numero di sconfitte
                dataTable = dv.ToTable();
                Table.DataSource = dataTable;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            string originalFilePath = "C:\\Users\\besom\\Desktop\\ProgettoTPS\\assets\\Tables\\team.csv";

            if (File.Exists(originalFilePath))
            {
                dataTable = ReadCSV(originalFilePath);

                Table.DataSource = dataTable;

                MessageBox.Show("La tabella è stata ripristinata al suo stato originale.");
            }
        }

        private void oldestFoundation_Click(object sender, EventArgs e)
        {
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Trova l'anno di fondazione più lontano
                var oldestYear = dataTable.AsEnumerable()
                    .Select(row => int.Parse(row.Field<string>("year_founded")))
                    .Min();

                // Ordina le squadre per anzianità di fondazione
                DataView dv = dataTable.DefaultView;
                dv.Sort = "year_founded ASC"; // Ordina in modo ascendente per l'anno di fondazione
                dataTable = dv.ToTable();
                Table.DataSource = dv.ToTable();
            }
        }

        private void recentFountation_Click(object sender, EventArgs e)
        {
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Trova l'anno di fondazione più lontano
                var oldestYear = dataTable.AsEnumerable()
                    .Select(row => int.Parse(row.Field<string>("year_founded")))
                    .Max();

                // Ordina le squadre per anzianità di fondazione
                DataView dv = dataTable.DefaultView;
                dv.Sort = "year_founded DESC"; // Ordina in modo ascendente per l'anno di fondazione
                dataTable = dv.ToTable();
                Table.DataSource = dv.ToTable();
            }
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se l'evento è stato scatenato da una cella di dati (non dall'intestazione)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Ottieni l'abbreviazione e il nome completo della squadra dalla cella selezionata
                string teamAbbreviation = Table.Rows[e.RowIndex].Cells["abbreviation"].Value.ToString();
                string teamName = Table.Rows[e.RowIndex].Cells["full_name"].Value.ToString();

                // Apri la finestra TeamPlayersForm e passa l'abbreviazione e il nome della squadra
                ShowTeamDetailsForm(teamAbbreviation, teamName);
            }
        }

        private void ShowTeamDetailsForm(string teamAbbreviation, string teamName)
        {
            // Crea una nuova istanza della finestra dei dettagli della squadra
            TeamPlayersStats teamDetailsForm = new TeamPlayersStats(teamAbbreviation, teamName);

            // Mostra la finestra dei dettagli della squadra
            teamDetailsForm.ShowDialog();
        }

    }
}

