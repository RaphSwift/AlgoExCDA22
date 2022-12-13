using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapillonMeta
{
    public class Lepidoptere
    {
        private StadeEvolution stadeCourant;
        public Lepidoptere()
        {
            this.stadeCourant = new Oeuf();
        }
        public string SeDeplacer()
        {
           return this.stadeCourant.SeDeplacer();
        }

        public void SeMetaphormoser()
        {
            this.stadeCourant = this.stadeCourant.SeMetamorphoser();
        }
    }
}
