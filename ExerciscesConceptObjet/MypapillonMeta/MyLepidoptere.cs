using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPapillonMeta
{
    public class MyLepidoptere
    {
        private MyStadeEvolution myStadeCourant;
        public MyLepidoptere()
        {
            this.myStadeCourant = new MyOeuf();
        }
        public string MySeDeplacer()
        {
            return this.myStadeCourant.MySeDeplacer();
        }
        public void MySeMetamorphoser()
        {
            this.myStadeCourant = this.myStadeCourant.MySeMetamorphoser();
        }

        public override string ToString()
        {
            return base.ToString() + " myStadeCourant= " + myStadeCourant.ToString();
        }
    }
}