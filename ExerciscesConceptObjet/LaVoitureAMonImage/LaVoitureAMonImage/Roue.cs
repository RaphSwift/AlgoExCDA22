using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LaVoitureAMonImage
{
    public class Roue
    {
        private bool tourne;
        private string dimensionPneu;

        public bool Tourne { get => tourne; /*set => tourne = value;*/ }

        /// Constructeur generique dune roue
        public Roue(bool _tourne, string _dimensionPneu)
        {
            this.tourne = _tourne;
            this.dimensionPneu = _dimensionPneu;
        }

        /// Constructeur par defaut dune roue
        /// 
        //
        public Roue()
        {

            this.tourne = false;
            this.dimensionPneu = "1.0";
        }
        /// public Roue() : this(false, "1.0") {} 
        /// Constructeur par copie dune roue
        /// 

        public Roue(Roue _roueACopier)
        {
            this.tourne = _roueACopier.tourne;
            this.dimensionPneu = _roueACopier.dimensionPneu;
        }
        /*public Roue(Roue _roueACopier) :
             this(_roueACopier.tourne,
                 _roueACopier.dimensionPneu){}*/
        public bool Tourner()
        {
            if (this.tourne == true)
            {
                return false;
            }
            else
            {
                this.tourne = true;
                return true;
            }
        }

        //Methode pour stopper une roue

        public bool Stopper()
        {
            if (this.Tourne)
            {
                this.tourne = false;
                return true;
            }
            return false;
        }
    }
}


