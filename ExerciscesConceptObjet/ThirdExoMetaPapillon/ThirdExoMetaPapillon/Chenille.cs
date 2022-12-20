using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdExoMetaPapillon
{
    public class Chenille : StadeEvolution
    {
        public Chenille() { }
        public override string SeDeplacer()
        {
            return "Scrawl";
        }
        public override StadeEvolution SeMetamorphoser()
        {
            return new Chrysalide();
        }
    }
}
