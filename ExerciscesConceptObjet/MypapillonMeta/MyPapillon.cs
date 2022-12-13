using MyPapillonMeta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPapillonMeta
{
    public class MyPapillon : MyStadeEvolution
    {
        public override string MySeDeplacer()
        {
            return "Fly.";
        }

        public override MyStadeEvolution MySeMetamorphoser()
        {
            return this;
        }
    }
}
