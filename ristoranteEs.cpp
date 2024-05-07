#include <iostream>
using namespace std;

// Creazione della lista
// Con i puntatori
struct Menu {
    // Contiene una stringa con il nome del piatto
    string Nome;
    // Un float con il prezzo del piatto
    float Prezzo;
    // Un puntatore che punta al
    // Prossimo della lista
    struct Menu *prossimo;
    // O a quella precedente della lista
    struct Menu *precedente;
};

// Funzione che
// Inserisce un nuovo elemento di tipo
// Menu alla lista (In fondo)
void inserisciPiatto(struct Menu **testa) {
    // Stringa per contenere il nome del nuovo piatto
    string nuovoNomePiatto;
    // Float per contenere il prezzo del nuovo piatto
    float nuovoPrezzo;

    // Dichiarazione delle variabili
    cout << "Inserisci il nome del nuovo piatto: " << endl;
    cin >> nuovoNomePiatto;
    cout << "Inserisci il prezzo del nuovo piatto: " << endl;
    cin >> nuovoPrezzo;

    // Dichiarare lo spazio di memoria per
    // Il nuovo elemento alla lista
    struct Menu* nuovoPiatto = new Menu;

    // Si assegnano i dati allo spazio di memoria
    // Del nuovo elemento
    nuovoPiatto->Nome = nuovoNomePiatto;
    nuovoPiatto->Prezzo = nuovoPrezzo;

    // Visto che il prossimo elemento non esiste ancora,
    // Si mette il puntatore al prossimo della lista
    // Come nulla
    nuovoPiatto->prossimo = NULL;

    // Dichiariamo la testa del nodo temporaneamente
    // (Servirà dopo per aggiungere l'elemento in fondo alla lista)
    struct Menu* temporaneo = *testa;

    // Se la lista è vuota (quindi nulla)
    // Allora si crea una nuova testa
    // (Non servirà in questo caso, visto che la testa è dichiarata nel Main)
    if (*testa == NULL) {
        nuovoPiatto->precedente = NULL;
        *testa = nuovoPiatto;
        return;
    }

    // Se la lista non è vuota, allora si utilizza un ciclo while
    // Che scorre la lista finchè il prossimo
    // Elemento della lista temporanea non è nulla
    // (visto che è una copia della testa, contiene i stessi elementi)
    // Quindi la testa contiene tutti i elementi della lista
    // Collegati ad essi
    while (temporaneo->prossimo != NULL)
        temporaneo = temporaneo->prossimo;

    // Ora che il prossimo della lista temporanea
    // è vuota

    // Si assegna al prossimo della lista temporanea il nuovo elemento di tipo Menu
    // che è il nuovoPiatto collegando la lista tutto insieme
    temporaneo->prossimo = nuovoPiatto;

    // Si assegna al puntatore verso il precedente del nuovo elemento,
    // la lista temporanea
    nuovoPiatto->precedente = temporaneo;
    cout << endl;
}

// stampa a video della lista
void stampaMenu(struct Menu* menu) {
    // Dichiarazione di un elemento di tipo Menu
    // Per indicare l'ultimo nodo che la stampa
    // Ha fatto accesso
    struct Menu *ultimo;

    while (menu != NULL) {
        // Ciclo while che scorre la lista
        // Finchè non è finita (Nulla)
        cout << "Nome del piatto: " << menu->Nome << endl;
        cout << "Prezzo del piatto: " << menu->Prezzo << " euro" << endl << endl;
        ultimo = menu;
        // Ricorda l'ultimo elemento della lista
        // Che ha stampato
        menu = menu->prossimo;
        // Passa al prossimo elemento della lista
    }
    cout << endl;
}
// stampa a video la lista, filtrando tutti i piatti che
// Hanno un prezzo uguale o minore di 20 euro
void cercaPiattiEco(struct Menu* menu) {
    // Dichiarazione di un elemento di tipo Menu
    // Per indicare l'ultimo nodo che il ciclo ha
    // Fatto accesso, nel caso serva dopo
    struct Menu* ultimo;

    while (menu != NULL) {
        // Ciclo per scorrere il menu
        // Finchè non arriva alla fine
        // Ossia che essa diventa vuota
        if (menu->Prezzo <= 20){
            // Filtraggio dei piatti, il nome e
            // Prezzo del piatto viene stampato
            // Solo se il prezzo è minore o uguale
            // Di 20 euro
            cout << "Nome del piatto: " << menu->Nome << endl;
            cout << "Prezzo del piatto: " << menu->Prezzo << " euro" << endl << endl;
        }
        ultimo = menu;
        // Ricorda l'ultimo elemento della lista
        // il while sta scorrendo
        menu = menu->prossimo;
        // Passa al prossimo elemento della lista
    }
    cout << endl;
}

// Il Main
int main()
{
    cout << "Esercizio Ristorante Menu" << endl;
    // Titolo e intestazione del progetto

    struct Menu *testa = NULL;
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
            cout << "Scelga una delle seguenti opzioni" << endl;
            cout << "1. Inserire un piatto e prezzo" << endl;
            cout << "2. Stampare il menu" << '\n';
            cout << "3. cercare tutti i piatti che costano meno di 20 euro" << endl;
            // Per favore, non mettete una stringa in questo cin
            cin >> scelta;
            cout << endl;
        }
        // La scelta dell'utente và a selezionare
        // Funzioni differenti
        if (scelta == 1){
            inserisciPiatto(&testa);
        }
        else if (scelta == 2){
            stampaMenu(testa);
        }
        else if (scelta == 3){
            cercaPiattiEco(testa);
        }
        // Ciclo per chiedere all'utente se vuole
        // Riutilizzare il menu per compiere un'altra
        // Azione o chiudere il programma
        while (finisci != 1 && finisci != 2){ // E si assicura che l'utente inserisca o 1 o 2
            cout << "Desidera chidudere il programma?" << endl;
            cout << "Inserire 1 per chiudere, inserire 2 per ripetere le azioni." << endl;
            cin >> finisci;
        }
        if (finisci == 1) // Se l'utente decide di selezionare 1, allora il programma finisce
            EndProgram = true;
    }   // Altrimenti, ritorna al ciclo originale per rifare il menu
    return 0;
}
