using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapillonMeta
{
    public class Oeuf : StadeEvolution
    {
        public Oeuf() { }
        public override string SeDeplacer()
        {
            return "reste sur place";

        }
        public override StadeEvolution SeMetamorphoser()
        {
            return new Chenille();
        }
    }
}
