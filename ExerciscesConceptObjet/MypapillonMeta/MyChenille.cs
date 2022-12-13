using MyPapillonMeta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPapillonMeta
{
    public class MyChenille : MyStadeEvolution
    {
        public MyChenille() { }
        public override string MySeDeplacer()
        {
            return "Scrawl";
        }
        public override MyStadeEvolution MySeMetamorphoser()
        {
            return new MyChrysalide();
        }
    }
}
