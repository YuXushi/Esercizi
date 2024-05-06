#include <iostream>

using namespace std;

struct Menu{
    string nomePiatto;
    float prezzo;
    struct Menu *prossimo;
    struct Menu *precedente;
};
int conta = 0;

void aggiungiPiatto (Menu cibo){
    int scelta;
    while (scelta != 1)
    {
        struct Menu *testa;
        struct Menu *conta = NULL;
        struct Menu *conta+1 = NULL;
        conta = malloc(sizeof(struct Menu))
        conta+1 = malloc(sizeof(struct Menu))
        cout << "Inserire il nome del piatto" << endl;
        cin >> conta->nomePiatto;
        cout << "Inserire il prezzo del piatto" << endl;
        cin >> conta+1->prezzo;
        conta += 2;
    }
}
void stampaMenu (Menu cibo){

}
void cercaPiattiPoveri (Menu cibo){

}

int main()
{
    Menu cibo;
    int scelta = 0;
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
        aggiungiPiatto(cibo);
    else if (scelta == 2)
        stampaMenu(cibo);
    else if (scelta == 3)
        cercaPiattiPoveri(cibo);
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
