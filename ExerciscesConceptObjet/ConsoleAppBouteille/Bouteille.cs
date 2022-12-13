using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBouteille
{
    public class Bouteille
    {
        public float contenanceEnCl;
        public float contenuEnCl;
        public bool estOuvert;
        public Bouteille()          // constructeur par default
        {
            contenanceEnCl = 100;
            contenuEnCl = 100;
            estOuvert = false;
        }

        // constructeur classique
        public Bouteille(float contenanceEnCl,
            float contenuActuelEnCl,
            bool estOuvert)
        {
            this.contenanceEnCl = contenanceEnCl;
            this.contenuEnCl = contenuActuelEnCl;
            this.estOuvert = estOuvert;
        }

        // constructeur par recopie (clonage)

        public Bouteille(Bouteille _bouteilleACopier)
        {
            contenanceEnCl = _bouteilleACopier.contenanceEnCl;
            contenuEnCl = _bouteilleACopier.contenuEnCl;
            estOuvert = _bouteilleACopier.estOuvert;

        }


        public bool Ouvrir()
        {
            if (!estOuvert)
            {
                estOuvert = true;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Fermer()
        {
            if (!estOuvert)
            {
                estOuvert = false;
            }
            return true;
        }
        public bool Remplir(float quantiteARemplir)
        {
            if ((quantiteARemplir > 0) && (estOuvert == true) && (contenuEnCl + quantiteARemplir < contenanceEnCl))
            {
                contenuEnCl = contenuEnCl + quantiteARemplir;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Vider(float quantiteAVider)
        {

            return true;
        }

        public bool RemplirTout()
        {
            return true;
        }

        public bool ViderTout()
        {
            return true;
        }
    }
    }
