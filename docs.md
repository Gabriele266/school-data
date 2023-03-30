# SchoolData docs
SchoolData è un progetto con il duplice scopo di:  
* Visualizzare grafici relativi agli studenti di determinate classi
* Permettere l'accesso agli insegnanti ed amministratori per gestire le informazioni sul portale

## Autenticazione
L'autenticazione viene fornita con 2 possibili ruoli di accesso: Amministratore e Insegnante. L'amministratore può visualizzare le classi e anche modificarle, mentre l'insegnante solo di visualizzare i grafici. 

## Struttura dei dati
La struttura dei dati è la seguente:

Studente (Id [PK], Nome, Cognome, Assenze, Classe [FK], VotoMedio)

L'entità studente rappresenta uno studente della scuola, che fa parte di una classe, rappresentata da un'altra entità in relazione one-to-many:
Classe

## Visualizzazione dei grafici
