#include <iostream>

using namespace std;

struct Menu
{
    string nomePiatto;
    float prezzo;
    string* ptrNome = &nomePiatto;
    float* ptrPrezzo = &prezzo;
};

void aggiungiPiatto (Menu cibo){
    cout << cibo.ptrNome << endl;
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
