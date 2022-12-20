using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdExoMetaPapillon
{
    public class Chrysalide : StadeEvolution
    {
        public Chrysalide() { }
        public override string SeDeplacer()
        {
            return "Is hung.";
        }
        public override StadeEvolution SeMetamorphoser()
        {
            return new Papillon();
        }
    }
}
