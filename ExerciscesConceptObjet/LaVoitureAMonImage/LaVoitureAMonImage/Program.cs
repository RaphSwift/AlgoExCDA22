
/*using LaVoitureAMonImage;
using MaVoiture;

Voiture voiture_parDefaut = new Voiture();

bool rt1 = voiture_parDefaut.Demarrer(); //true
bool rt2 = voiture_parDefaut.Avancer(); //true
bool rt3 = voiture_parDefaut.Avancer(); //false
bool rt4 = voiture_parDefaut.CouperContact(); //false
bool rt5 = voiture_parDefaut.Freiner(); //true
bool rt6 = voiture_parDefaut.Freiner(); //false
bool rt7 = voiture_parDefaut.CouperContact(); //true
bool rt8 = voiture_parDefaut.CouperContact(); //false
bool rt9 = voiture_parDefaut.Freiner(); //false
bool rt10 = voiture_parDefaut.Avancer(); //false

Roue roue_parDefaut = new Roue();

bool rt11 = roue_parDefaut.Stopper(); //false
bool rt12 = roue_parDefaut.Tourner(); //true
bool rt13 = roue_parDefaut.Tourner(); //false
bool rt14 = roue_parDefaut.Stopper(); //true


Roue[] roues = new Roue[4] { new Roue(), new Roue(), new Roue(), new Roue() };
Moteur moteur = new Moteur();
string marque = "Citroen";

Voiture voitue = new Voiture(marque, moteur, roues);

Roue roueA = new Roue();
Roue roueB = new Roue();
Roue roueC = new Roue();
Roue roueD = new Roue();
Moteur moteurB = new Moteur();

Voiture voitureB =new Voiture(marque, moteur, RoueA, RoueB, RoueC, roueD);

Voiture voitureC = new Voiture(marque,false, true,  );

int i = 0;

*/

using LaVoitureAMonImage;

Roue[] roues = new Roue[] { new Roue(), new Roue(), new Roue(), new Roue(), new Roue(), new Roue() };
Moteur moteur = new Moteur();
string marque = "Citroen";
//Utilisation du constructeur V1 : public Voiture(string _marque, Moteur _sonMoteur, Roue[] _ses4roues)
Voiture voiture = new Voiture(marque, moteur, roues);
Roue roueA = new Roue();
Roue roueB = new Roue();
Roue roueC = new Roue();
Roue roueD = new Roue();
Moteur moteurB = new Moteur();
//Utilisation du constructeur V2 : public Voiture(string _marque, Moteur _sonMoteur,
//Roue _roue1, Roue _roue2, Roue _roue3, Roue _roue4)
Voiture voitureB = new Voiture(marque, moteur, roueA, roueB, roueC, roueD);
//Utilisation du constructeur V3 : public Voiture(string _marque, bool _enMarche,
// bool _tourne, string _dimensionPneu)
Voiture voitureC = new Voiture(marque, false, false, "240/15/10V");
