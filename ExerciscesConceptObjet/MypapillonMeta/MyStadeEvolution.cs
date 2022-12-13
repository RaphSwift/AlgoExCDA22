using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPapillonMeta
{
    public abstract class MyStadeEvolution
    {
        public MyStadeEvolution() { }
        public abstract string MySeDeplacer();
        public abstract MyStadeEvolution MySeMetamorphoser();
    }


}

