using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace ProgettoTPS
{
    public partial class NBA_Teams : Form
    {
        public NBA_Teams()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Imposta il percorso del file CSV
            string filePath = "C:\\Users\\besom\\Desktop\\ProgettoTPS\\SquadNBA\\team.csv";

            // Controlla se il file esiste
            if (File.Exists(filePath))
            {
                // Leggi i dati dal file CSV e caricali in un DataTable
                DataTable dataTable = ReadCSV(filePath);

                // Imposta il DataTable come origine dati del DataGridView
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Il file CSV non esiste.");
            }
        }

        private DataTable ReadCSV(string filePath)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    // Leggi la prima riga per ottenere i nomi delle colonne
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    // Leggi il resto delle righe
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataRow[i] = rows[i];
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante la lettura del file CSV: " + ex.Message);
            }

            return dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

