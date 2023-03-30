# SchoolData docs
SchoolData è un progetto con il duplice scopo di:  
* Visualizzare grafici relativi agli studenti di determinate classi
* Permettere l'accesso agli insegnanti ed amministratori per gestire le informazioni sul portale

## Autenticazione
L'autenticazione viene fornita con 2 possibili ruoli di accesso: Amministratore e Insegnante. L'amministratore può visualizzare le classi e anche modificarle, mentre l'insegnante solo di visualizzare i grafici. 

## Struttura dei dati
La struttura dei dati è la seguente:

Studente (Id [PK], Nome, Cognome, Assenze, Classe [FK], VotoMedio)

NOTA: Assenze rappresenta il numero di assenze

L'entità studente rappresenta uno studente della scuola, che fa parte di una classe, rappresentata da un'altra entità in relazione one-to-many:
Classe (Codice [PK], Specializzazione)

## Visualizzazione dei grafici
La visualizzazione dei grafici viene gestita tramite la libreria **ChartJS** che permette di creare grafici a barre, a torta e così via. 
Saranno basati sui dati relativi alle assenze e alla media dei voti. La libreria viene installata lato client ed è scritta in Javascript. 

## Architettura e tecnologie utilizzate
La applicazione utilizza il pattern architetturale MVC (Model View Controller) ed è realizzata in ASP.NET Core C#. Il database utilizzato è SQL Server. 