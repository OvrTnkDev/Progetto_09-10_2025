# Gestione di un Giornale

Un software che permette di gestire giornali fisici, modellando articoli, giornate di pubblicazione e copie vendute.
Il sistema utilizza una logica ad oggetti, con generazione casuale dei dati di vendita tramite la classe Random.

---

## Tecnologie

- Framework: .NET 9.0
- Linguaggio: C#
- Paradigma: Programmazione a Oggetti (OOP)
- Classe Random: utilizzata per simulare copie vendute e altre variabili casuali

---

## Struttura progetto

|── Program.cs                 # Entry point dell'applicazione
|── Utils/
│   ├── Articolo.cs            # Gestisce il corpo e i dettagli di un articolo
│   ├── Giornata.cs            # Gestisce i giorni di pubblicazione
│   └── Journal.cs             # Gestisce i giornali (titolo, data, copie, ecc.)



---

## Come funziona

- Creazione giornali: Il programma genera una lista di giornali con articoli casuali.
- Simulazione vendite: Utilizzando la classe Random, vengono assegnate casualmente le copie vendute per ogni giornale.
- Gestione giornate: Ogni giornata di pubblicazione contiene:
- Data di uscita
- Numero di copie disponibili
- Numero di copie vendute
- Articoli pubblicati

**Report finale**:
Alla fine dell’esecuzione, il programma stampa un riepilogo dei giornali pubblicati e delle vendite simulate.

---

## Prerequisiti

.NET 9.0 SDK installato
(verifica con dotnet --version)


** Istruzioni **

-1 Clona il repository:

- git clone https://github.com/OvrTnkDev/Progetto_09-10_2025.git
- cd Progetto_09-10_2025


-2 Compila ed esegui:

- dotnet run
