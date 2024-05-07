#include <iostream>
using namespace std;

// node creation
struct Menu {
    string Nome;
    float Prezzo;
    struct Menu* prossimo;
    struct Menu* precedente;
};

// insert a newNode at the end of the list
void inserisciPiatto(struct Menu** testa) {
    string nuovoNomePiatto;
    float nuovoPrezzo;
    cout << "Inserisci il nome del nuovo piatto: " << endl;
    cin >> nuovoNomePiatto;
    cout << "Inserisci il prezzo del nuovo piatto: " << endl;
    cin >> nuovoPrezzo;

    // allocate memory for node
    struct Menu* nuovoPiatto = new Menu;

    // assign data to newNode
    nuovoPiatto->Nome = nuovoNomePiatto;
    nuovoPiatto->Prezzo = nuovoPrezzo;

    // assign null to next of newNode
    nuovoPiatto->prossimo = NULL;

    // store the head node temporarily (for later use)
    struct Menu* temporaneo = *testa;

    // if the linked list is empty, make the newNode as head node
    if (*testa == NULL) {
        nuovoPiatto->precedente = NULL;
        *testa = nuovoPiatto;
        return;
    }

    // if the linked list is not empty, traverse to the end of the linked list
    while (temporaneo->next != NULL)
        temporaneo = temporaneo->prossimo;

    // now, the last node of the linked list is temp

    // assign next of the last node (temp) to newNode
    temporaneo->prossimo = nuovoPiatto;

    // assign prev of newNode to temp
    nuovoPiatto->precedente = temporaneo;
}

// print the doubly linked list
void stampaMenu(struct Menu* node) {
    struct Menu* ultimo;

    while (node != NULL) {
        cout << "Nome del piatto: " << node->Nome << endl;
        cout << "Prezzo del piatto: " << node->Prezzo << endl << endl;
        ultimo = node;
        node = node->prossimo;
    }
}
void cercaPiattiPoveri(struct Menu* node) {
    struct Menu* ultimo;

    while (node != NULL) {
        if (node->Prezzo <= 20){
            cout << "Nome del piatto: " << node->Nome << endl;
            cout << "Prezzo del piatto: " << node->Prezzo << endl << endl;
        }
        ultimo = node;
        node = node->prossimo;
    }
}

int main()
{
    struct *testa = NULL;
    // Dichiarazione del puntatore testa della lista

    bool EndProgram = false;
    // Booleano per far ripetere le azioni all'utente
    int finisci;
    // Intero per far scegliere all'utente se vuole
    // Chiudere il programma o fare un'altra azione
    // Sul menu scelte
    while (EndProgram != true)
    {   // While per far ripetere il programma
        finisci = 0;
        int scelta = 0;
        // Dichiarazione di variabile per far scegliere all'utente
        // Le seguenti azioni
        while (scelta != 1 && scelta != 2 && scelta != 3)
        {   // Ciclo while per assicurare che l'utente metta una delle seguenti opzioni
            cout << "Esercizio Ristorante Menu" << endl;
            cout << "Scelga una delle seguenti opzioni" << endl;
            cout << "1. Inserire un piatto e prezzo" << endl;
            cout << "2. Stampare il menu" << '\n';
            cout << "3. cercare tutti i piatti che costano meno di 20 euro" << endl;
            // Per favore, non mettete una stringa in questo cin
            cin >> scelta;
        }
        if (scelta == 1){
            inserisciPiatto(&testa);
        }
        else if (scelta == 2){
            stampaMenu(testa);
        }
        else if (scelta == 3){
            cercaPiattiPoveri(testa);
        }
        while (finisci != 1 && finisci != 2){
            cout << "Desidera chidudere il programma?" << endl;
            cout << "Inserire 1 per chiudere, inserire 2 per ripetere le azioni." << endl;
            cin >> finisci;
        }
        if (finisci == 1)
            EndProgram = true;
    }
    return 0;
}
