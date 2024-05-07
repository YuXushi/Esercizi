#include <iostream>

using namespace std;

struct Menu{
    string nomePiatto;
    float prezzo;
    struct Menu *prossimo;
    struct Menu *precedente;
};

void aggiungiPiatto (float NuovoPrezzo, string NomeNuovoPiatto, struct Menu **Testa){
        cout << "Inserire il nome del nuovo piatto:" << endl;
        cin >> NomeNuovoPiatto;
        cout << "Inserire il prezzo del nuovo piatto:" << endl;
        cin >> NuovoPrezzo;
        cout << NomeNuovoPiatto << endl;
        cout << NuovoPrezzo << endl;
        struct Menu* NuovoPiatto = new Menu;
        NuovoPiatto.nomePiatto = NomeNuovoPiatto;
        NuovoPiatto.prezzo = NuovoPrezzo;
        NuovoPiatto.prossimo = (*Testa);
        NuovoPiatto.precedente = NULL;
        if ((*Testa) != NULL)
            (*Testa)->precedente = NuovoPiatto;
        (*Testa) = NuovoPiatto;
}
void stampaMenu (){

}
void cercaPiattiPoveri (){

}

int main()
{
    Menu testa;
    float nuovoPrezzo;
    string nomeNuovoPiatto;
    int scelta;
    while (scelta != 1 && scelta != 2 && scelta != 3)
    {
        cout << "Esercizio Ristorante Menu" << endl;
        cout << "Scelga una delle seguenti opzioni" << endl;
        cout << "1. Inserire un piatto e prezzo" << endl;
        cout << "2. Stampare il menu" << '\n';
        cout << "3. cercare tutti i piatti che costano meno di 20 euro" << endl;
        cin >> scelta;
    }
    if (scelta == 1)
        aggiungiPiatto(nuovoPrezzo, nomeNuovoPiatto, testa);
    else if (scelta == 2)
        stampaMenu();
    else if (scelta == 3)
        cercaPiattiPoveri();
    return 0;
}

/*
source link: https://www.programiz.com/dsa/doubly-linked-list


struct node {
    int data;
    struct node *next;
    struct node *prev;
}

-----------------------

Initialize nodes

struct node *head;
struct node *one = NULL;
struct node *two = NULL;
struct node *three = NULL;

Allocate memory

one = malloc(sizeof(struct node));
two = malloc(sizeof(struct node));
three = malloc(sizeof(struct node));

Assign data values

one->data = 1;
two->data = 2;
three->data = 3;

Connect nodes

one->next = two;
one->prev = NULL;

two->next = three;
two->prev = one;

three->next = NULL;
three->prev = two;

Save address of first node in head

head = one;
*/
