using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LaVoitureAMonImage
{
    public class Voiture
    {
        private string marque;
        private Moteur sonMoteur;
        private Roue[] ses4roues;

        //version dictionnaire
        //private Dictionary<string, Roue> ses4Roues2;


        ///Constructeur par defaut de voiture


        public Voiture()
        {
            this.marque = "Peugeot";
            this.sonMoteur = new Moteur();

            //this.ses4roues = new Roue[4] {new Roue(), new Roue(), new Roue(), new Roue()}

            this.ses4roues = new Roue[4];
            this.ses4roues[0] = new Roue(); //roue avant droite
            this.ses4roues[1] = new Roue(); //roue avant gauche
            this.ses4roues[2] = new Roue(); //roue arriere droite
            this.ses4roues[3] = new Roue(); //roue arriere gauche

            //version dictionnaire
            /*ses4Roues2 = new Dictionary<string, Roue>();
             ses4Roues2.Add("rad", new Roue());
             ses4Roues2.Add("rag", new Roue());
             ses4Roues2.Add("rard", new Roue());
             ses4Roues2.Add("rarg", new Roue());*/

            ///Appelle la methode Demarrer de Moteur
            ///
        }
        /// Constructeur classic dune voiture V1
        public Voiture(string _marque, Moteur _sonMoteur, Roue[] _ses4roues)
        {
            this.marque = _marque;
            this.sonMoteur = _sonMoteur;
            this.ses4roues = _ses4roues;
        }

        /// Constructeur classic dune voiture V2

        public Voiture(string _marque, Moteur _sonMoteur, Roue _roue1, Roue _roue2,
            Roue _roue3, Roue _roue4)
        {
            this.marque = _marque;
            this.sonMoteur = _sonMoteur;
            this.ses4roues = new Roue[4] { _roue1, _roue2, _roue3, _roue4 };
        }

        /// Encore un autre constructeur classic de voitue V3

        public Voiture(string _marque, bool _enMarche, bool _tourne, string _dimensionPneu)
        {
            this.marque = _marque;
            this.sonMoteur = new Moteur(_enMarche);
            this.ses4roues = new Roue[4] {new Roue(_tourne, _dimensionPneu),
            new Roue(_tourne, _dimensionPneu), new Roue(_tourne, _dimensionPneu),
            new Roue(_tourne, _dimensionPneu)};
        }

        /// Constructeur par copie de voiture
        /* public voiture (Voiture _voitureACopier)
         {
            this.marque = _voitureACopier.marque;
            this.sonMoteur = new Moteur(_voitureACopier.sonMoteur);
            //this.sonMoteur = _voitureACopier.sonMoteur; //ne pas faire ça 
            this.ses4roues = new Roue[] {new Roue(_voitureACopier.ses4roues[0]),
            new Roue(_voitureACopier.ses4roues[1]),
            new Roue(_voitureACopier.ses4roues[2]),
            new Roue(_voitureACopier.ses4roues[3])};
        }*/

        /// Autre constructeur par recopie avec référence avec un constructeur classique.

        public Voiture(Voiture _voitureACopier) : this(_voitureACopier.marque,
            new Moteur(_voitureACopier.sonMoteur),
            new Roue[] { new Roue(_voitureACopier.ses4roues[0]),
            new Roue(_voitureACopier.ses4roues[1]),
            new Roue(_voitureACopier.ses4roues[2]),
            new Roue(_voitureACopier.ses4roues[3])})
        { }
        // Appelle la methode Demarrer de Moteur

        public bool Demarrer()
        {
            return sonMoteur.Demarrer();
        }
        /// Permet d'appeler la méthode EntrainerRoue de Moteur. 

        public bool Avancer()
        {
            return sonMoteur.EntrainerRoue(ses4roues[0], ses4roues[1]);
            //return sonMoteur.EntrainerRoue(ses4Roues2["rad"], ses4Roues2["rag"])
        }

        /// Permet dappeler la methode Freiner de Moteur
        public bool Freiner()
        {
            return sonMoteur.ArreterRoues(ses4roues[0], ses4roues[1]);
        }

        /// Permet d'éteindre le moteur si les roues ne tournent pas.

        public bool CouperContact()
        {
            //ses4roues[0].Tourne = true; impossible car pas de set dans la propriété Tourne. 
            //if !(ses4roues[0].Tourne || ses4roues[1].Tourne)
            //if (ses4roues[0].Tourne==false && ses4roues[1].Tourne==false)

            if (!ses4roues[0].Tourne && !ses4roues[1].Tourne)
            {
                return sonMoteur.Eteindre();
            }
            return false;
        }
    }
}

