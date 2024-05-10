#include <iostream>

using namespace std;


// crea una casella composta da 3 parti:
// Titolo, Autore, Prezzo -> Prossima casella
//
// Si deve sempre tenere conto della testa delle caselle
// Si usa next per passare alla prossima casella
// Se si perde testa, allora non è più possibile scorrere la testa

/* typedef struct El {
    string Titolo;
    string Autore;
    float Prezzo;
    struct El *next;
} ELEMENTO; // Nome della struct (?) */

// Esercizio:
// Si codifichi in C la funzione somma avente il seguente prototipo:
// int somma (ELEMENTO *Testa, int M)
// tale funzione riceve come parametro la testa della lista
// e un intero M. Quindi, restituisce la somma dei soli valori della lista che sono
// Multipli di M e se la lista è vuota, la funzione restituisce il valore -1.

typedef struct dati {
    int valore;
    struct dati *next;
} ELEMENTO;

// Possiamo mettere in input un ELEMENTO temporaneo, invece della vera testa
int somma(ELEMENTO *Testa, int input){
    int sum = 0;

    if (Testa == NULL)
        return(-1);
    else {
        while (Testa != NULL)
            if(Testa->valore % input == 0)
                sum = sum + Testa->valore;
            Testa = Testa->next;
    }
    return sum;
}

int find_Max(ELEMENTO *Testa){
    int max = -1;
    while (Testa != NULL)
        if (max < Testa->valore)
            max = Testa->valore;
        Testa = Testa->next;
    return max;
}

void Inserisci_Coda (ELEMENTO *Testa, int input){
    ELEMENTO *NewNode;
    NewNode->valore = input;
    NewNode->next = NULL;
    if (Testa == NULL)
        Testa = NewNode;
    else{
    while (Testa->next != NULL)
        Testa = Testa->next;
    Testa->next = NewNode;
    }
}
void Inserisci_Testa (ELEMENTO *Testa, int input){
    ELEMENTO *NewNode;
    NewNode->valore = input;
    NewNode->next = Testa; // il NewNode->next = Testa copia solo il Testa->next e non Testa->valore di Testas
    Testa = NewNode;
}


int main()
{
    return 0;
}
// Per casa:

// #include <iostream>

// #include <string>

// using namespace std;

/*
struct vettura
{
    string targa;
    int cilindrata;
    struct vettura *next;
}

int main()
{
    vettura*
    [...]

}


1) inserire in testa una nuova auto
2) eliminare in testa un'auto
3) Ricercare un'auto tramite targa
4) contate quante auto hanno un determinata cilindrata (da dare in input)



*/
//

