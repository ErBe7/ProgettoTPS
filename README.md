# ProgettoTPS

### Analisi del Codice

#### Parte relativa alle squadre NBA (NBA_Teams)

Il namespace `ProgettoTPS` contiene la classe `NBA_Teams`, che estende `Form`. Questa classe gestisce l'interfaccia grafica per visualizzare le informazioni sulle squadre NBA.

- **Variabili di Classe**: La classe utilizza variabili di classe private per memorizzare i dati delle squadre e le liste delle squadre delle due conference.

- **Costruttore**: Il costruttore `NBA_Teams` inizializza le liste delle squadre delle conference.

- **Metodo `Form1_Load`**: Questo metodo viene eseguito quando il form viene caricato. Legge i dati dal file CSV delle squadre, popola le liste delle squadre delle conference e visualizza i dati in una DataGridView.

- **Metodo `ReadCSV`**: Questo metodo legge i dati da un file CSV e li converte in un oggetto DataTable.

- **Altri Metodi**: La classe contiene metodi per filtrare le squadre per conference, ordinare le squadre per vittorie e sconfitte, e ripristinare la tabella allo stato originale.

#### Parte relativa alle statistiche dei giocatori (TeamPlayersStats)

Il namespace `ProgettoTPS` contiene la classe `TeamPlayersStats`, che estende `Form`. Questa classe gestisce l'interfaccia grafica per visualizzare le statistiche dei giocatori di una squadra NBA.

- **Variabili di Classe**: La classe utilizza variabili di classe private per memorizzare i dati dei giocatori e i dati filtrati.

- **Costruttore**: Il costruttore `TeamPlayersStats` inizializza l'interfaccia grafica, carica i dati dei giocatori e l'immagine della squadra selezionata.

- **Metodo `LoadPlayers`**: Questo metodo legge i dati dei giocatori dal file CSV, li filtra per la squadra selezionata e li visualizza in una DataGridView.

- **Metodo `ReadCSV`**: Questo metodo legge i dati da un file CSV e li converte in un oggetto DataTable.

- **Altri Metodi**: La classe contiene metodi per gestire il click sulle celle della DataGridView, ordinare e filtrare i dati dei giocatori, e ripristinare la tabella allo stato originale.

### Considerazioni

- Il codice è ben strutturato e organizzato in classi separate per gestire le squadre e i giocatori.
  
- Viene utilizzato l'approccio Object-Oriented Programming (OOP) per separare la logica di presentazione dalla logica di business.

- Sono presenti controlli per gestire casi di errore, ad esempio quando i file CSV non sono trovati o quando non ci sono dati da visualizzare.

- I metodi sono abbastanza chiari nella loro funzione e ben commentati, il che facilita la manutenzione e la comprensione del codice.

- Potrebbe essere utile aggiungere ulteriori commenti per spiegare parti più complesse del codice o per fornire informazioni aggiuntive sui flussi di lavoro.