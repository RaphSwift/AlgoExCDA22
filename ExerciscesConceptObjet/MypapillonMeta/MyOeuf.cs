using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPapillonMeta
{
    /*public class MyOeuf : MyStadeEvolution
    {
        public override string MySeDeplacer()
        }
        return "Stay";
        public override MyStadeEvolution
        {
        return new MyChrysalide();
}
}
}*/

    class MyOeuf : MyStadeEvolution
    {
        public MyOeuf(){}
        public override string MySeDeplacer()
        {
            return "Static.";
        }
        public override MyStadeEvolution MySeMetamorphoser()
        {
            return new MyChenille();
        }

        public override string ToString()
        {
            return "C'est un oeuf";
        }
    }
}