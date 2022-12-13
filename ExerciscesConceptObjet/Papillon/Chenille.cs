﻿using PapillonMeta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapillonMeta
{
    public class Chenille : StadeEvolution
    {
        public Chenille() { }

        public override string SeDeplacer()
        {
            return "Je rampe. ";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Chrysalide();
        }
    }
}
