using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapillonMeta
{
    public class Chrysalide : StadeEvolution
    {
        public Chrysalide() { }
        public override string SeDeplacer()
        {
            return "Ne se deplace pas ";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Papillon();
        }
    }
}

