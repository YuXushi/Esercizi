#include <iostream>

using namespace std;

struct vettura{
    string targa;
    int cilindrata;
    struct vettura *next;
};

void inserisciAuto(struct vettura **Testa) {
    string newTarga;
    int newCilindrata;
    cout << "Numero Targa: ";
    cin >> newTarga;
    cout << "Cilindrata: ";
    cin >> newCilindrata;

    struct vettura* newVettura = new vettura;

    newVettura->targa = newTarga;
    newVettura->cilindrata = newCilindrata;

    newVettura->next = (*Testa);


    (*Testa) = newVettura;

    cout << "Nuova vettura aggiunta." << endl << endl;

}

void stampaGarage(struct vettura *Testa){
    while (Testa != NULL){
        cout << "Numero Targa: " << Testa->targa << endl;
        cout << "Cilindrata: " << Testa->cilindrata << endl << endl;
        Testa = Testa->next;
    }
}

void eliminaAuto(struct vettura *Testa) {
    string targaAuto;
    cout << "Inserire targa della auto da eliminare: ";
    cin >> targaAuto;
    while (Testa != NULL){
        if (Testa->targa == targaAuto){
            //????
        }
        Testa = Testa->next;
    }
}

void ricercaAuto(struct vettura *Testa) {
    string targaAuto;
    cout << "Inserire targa della auto: ";
    cin >> targaAuto;
    while (Testa != NULL){
        if (Testa->targa == targaAuto){
            cout << "Numero Targa: " << Testa->targa << endl;
            cout << "Cilindrata: " << Testa->cilindrata << endl << endl;
        }
        Testa = Testa->next;
    }
}

void contaAuto(struct vettura *Testa) {
    int cilindrata;
    cout << "Inserire una determinata cilindrata: ";
    cin >> cilindrata;
    int contaAuto = 0;
    while (Testa != NULL){
        if (Testa->cilindrata == cilindrata){
            contaAuto++;
        }
    }
    cout << "Numero di veicoli presenti nel garage con " << cilindrata
    << "sono " << contaAuto << endl;
}

int main()
{
    struct vettura *Testa = NULL;
    cout << "Esercizio vettura." << endl;
    bool fine = false;
    while (!fine){
        int scelta = 0;
        while (!(scelta > 0 && scelta < 7))
        {
            cout << "Scegli una delle seguenti opzioni:" << endl
            << "1. Inserire una nuova auto" << endl
            << "2. Eliminare una l'ultima auto inserita" << endl
            << "3. Cercare una auto tramite targa" << endl
            << "4. Stampare il garage" << endl
            << "5. Contare quante auto hanno una determinata cilindrata" << endl
            << "6. per uscire" << endl;
            cin >> scelta;
            cout << endl;
        }
        if (scelta == 1)
            inserisciAuto(&Testa);
        else if (scelta == 2)
            eliminaAuto(Testa);
        else if (scelta == 3)
            ricercaAuto(Testa);
        else if (scelta == 4)
            stampaGarage(Testa);
        else if (scelta == 5)
            contaAuto(Testa);
        else if (scelta == 6)
            fine = true;
    }
    return 0;
}

/*
1) inserire in testa una nuova auto
2) eliminare in testa un'auto
3) Ricercare un'auto tramite targa
4) contate quante auto hanno un determinata cilindrata (da dare in input)
*/
