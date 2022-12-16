using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaVoitureAMonImage
{
    public class Moteur
    {
        private bool enMarche;
        /// constructeur genereque d'un moteur
        public Moteur (bool _enMarche)
        {
            this.enMarche = _enMarche;
        }

        /// Constructeur par defaut dun moteur
        
        public Moteur()
        {
            this.enMarche=false;
        }
        //public Moteur() : this(false) {}

        /// COnstructeur par copie dun moteur
        
        public Moteur (Moteur _moteurACopier)
        {
            this.enMarche = _moteurACopier.enMarche;
        }

        ///Bascule enMarche de false à true
        ///Si enMarche est deja true, la methode ne fait rien
        ///Return false si deja enMarche est deja true ou returne
        ///  true si enMarche est initialement false.
        ///  

        public bool Demarrer()
        {
            if (this.enMarche == true)
            {
                return true;
            } 
            else
            {
                this.enMarche =true;
                return false;
            }
        }
        public bool EntrainerRoue (Roue roue1, Roue roue2)
        {
            if (this.enMarche)
            {
                bool rt1 = roue1.Tourner();
                bool rt2 = roue2.Tourner();
                if (rt1 == true && rt2 == true) // if (rt1 && rt2)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ArreterRoues(Roue roue1, Roue roue2)
        {
            bool rt1 = roue1.Stopper();
            bool rt2 = roue2.Stopper();
            if (rt1 && rt2)
            {
                return true;
            }
            return false;
        }
        /// Permet de passer enMarche de True à false.
        /// 

        public bool Eteindre()
        {
            if (this.enMarche)
            {
                this.enMarche = false;
                return true;
            }
            return false;
        }
    }
}
