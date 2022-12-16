using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdExoMetaPapillon
{
    public class Papillon : StadeEvolution
    {
        public Papillon() { }
        public override string SeDeplacer()
        {
            return "Flies";
        }
        public override StadeEvolution SeMetamorphoser()
        {
            return this;
        }
    }
}
