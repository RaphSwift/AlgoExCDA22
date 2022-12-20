using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ThirdExoMetaPapillon
{
    public class Oeuf: StadeEvolution
    {
        public Oeuf() { }
        public override string SeDeplacer()
        {
            return "Doesn't move."; 
        }
        public override StadeEvolution SeMetamorphoser()
        {
            return new Chenille();
        }
    }
}
