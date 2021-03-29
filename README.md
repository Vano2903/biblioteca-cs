# biblioteca-cs
biblioteca compito per informatica

richieste:

Si richiede l'applicazione per la simulazione di una biblioteca:
- gestione del parco libri (aggiungo libro, tolgo, libro, aggiorno prezzo,...)
- gestione dei prestiti di libri (ricerca, presa in prestito o prenotazione)
- ritiro effettivo del libro
- gestione ritardi nella riconsegna (elenco, comunicazione)
- rinnovo del prestito (1 solo se nessuno in prenotazione)
- se numero ritardi =3 bloccare per 1 mese la possibilità di ulteriori prestiti (ricordarsi di togliere il blocco alla scadenza)

All'avvio
- lettura della situazione dai file .json
- ricerca dei ritardatari e incremento del numero dei ritardi
- blocco del prestito se num ritardi=3
- sblocco alla scadenza (dopo 1 mese)
Ipotesi MENU
- Accesso riservato (bibliotecario)
- gestione libri (file .json o .csv)
- ritiro effettivo
- riconsegna del libro
- gestione ritardi
- Registrazione/Accesso utente (email)
- gestione prestito libro
- rinnovo prestito
- riconsegna libro

All'uscita:
- salvare tutte le informazioni in file .json

----------------------------------------------------------------------------------------------------------------------------
POSSIBILE PRIMA CONSEGNA
Definire Classe Biblioteca

Definire
o array globale per contenere tutti i libri
o classe VarGlobali che come attributo ha l'array di libri

menu (o form a pulsanti)per richiamare la form per ricevere gli attributi del libro(Titolo, Autore, ISBN, Prezzo) ed inserirlo nell'array

Metodo di Biblioteca per salvare i libri in un file json da richiamare all'uscita dell'applicazione.

Metodo di Biblioteca per leggere i libri da un file json da richiamare all'apertura dell'applicazione (mostrarli in una listbox per esempio).

