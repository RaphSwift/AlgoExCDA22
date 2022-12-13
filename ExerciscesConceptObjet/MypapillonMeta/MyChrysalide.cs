using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPapillonMeta
{

    public class MyChrysalide : MyStadeEvolution
    {
        public MyChrysalide() { }
        public override string MySeDeplacer()
        {
            return "Hung";
        }
        
     public override MyStadeEvolution MySeMetamorphoser()
        {
            return new MyPapillon();
        }
    }
}