
using ConsoleAppBouteille;

// Declaration

Bouteille bouteilleDeChampagne;    //int a;
Bouteille bouteilleDeEau;

bouteilleDeChampagne = new Bouteille(150,150,false);             // a=2;
//bouteilleDeChampagne = new Bouteille();


bouteilleDeEau = new Bouteille();


bool resultat= bouteilleDeEau.Ouvrir();

bool resultat2 = bouteilleDeEau.Ouvrir();

Console.ReadLine();
