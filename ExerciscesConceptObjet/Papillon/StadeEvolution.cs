// Métamorphose du lépidoptere 

/*   Créer nouvelle class*  On commence par la classe la moins dépendante!
 *   
 ** 
abstract class StadeEvolution
{
    public StadeEvolution()
    { }
    public abstract string SeDeplacer();
    public abstract StadeEvolution SeMetamorphoser();
}

* Creer nouvelle class *
**
class Oeuf : StadeEvolution
    {
        public Oeuf()
        {
        }
        public override string SeDeplacer()
        {
            return "Reste sur place";
        }
        public override StadeEvolution SeMetamorphoser()
        {
            return new Chenille();
        }
    }

* Creer nouvelle class *
**
class Chenille : StadeEvolution
    {
        public Chenille() 
        {
        }
        public override string SeDeplacer()
        {
            return "Je rampe.";
        }
        public override StadeEvolution SeMetamorphoser()
        {
            return new Chrysalide();
        }
    }

* Creer nouvelle class *
**
class Chrysalide :StadeEvolution
    {
        public Chrysalide()
        {
        }
        public override string SeDeplacer()
        {
            return "Ne se deplace pas";
        }
        public override StadeEvolution SeMetamorphoser()
        {
            return new Papillon();
        }
    }
* Creer nouvelle class *
**
class Papillon : StadeEvolution
    {
        public Papillon()
        {
        }
        public override string SeDeplacer()
        {
            return "Je vole.";
        }
        public override StadeEvolution SeMetamorphoser()
        {
            return this;
        }
    }

**Maintenant que l'on a fini les différents StadeEvolutions, on code le Lepidoptere
* Creer nouvelle class * 
**
public class Lepidoptere
    {
        private StadeEvolution stadeCourant;
        public Lepidoptere()
        {
            this.stadeCourant = new Oeuf();
        }
        public string SeDeplacer()
        {
           return this.stadeCourant.SeDeplacer();
        }
        public void SeMetamorphoser()
        {
            this.stadeCourant = this.stadeCourant.SeMetamorphoser();
        }
        public override string ToString()
        {
            return " stadeCourant = "+this.stadeCourant.ToString();
        }
    }
** Et on teste son code avec le console ou le debugger, en stimulant la métamorphose du Lepidoptere et en lui demandant de se deplacer à chaque moment

* Créer DANS LE FICHIER Program.cs
* 
 Lepidoptere monLepi = new Lepidoptere();
///  Stade Oeuf
Console.WriteLine(monLepi.SeDeplacer());
Console.WriteLine(monLepi);
monLepi.SeMetamorphoser();
///  Stade Chenille
Console.WriteLine(monLepi.SeDeplacer());
Console.WriteLine(monLepi);
monLepi.SeMetamorphoser();
///  Stade Chrysalide
Console.WriteLine(monLepi.SeDeplacer());
Console.WriteLine(monLepi);
monLepi.SeMetamorphoser();
///  Stade Papillon
Console.WriteLine(monLepi.SeDeplacer());
Console.WriteLine(monLepi);
monLepi.SeMetamorphoser();
///  Stade Toujours un papillon
Console.WriteLine(monLepi.SeDeplacer());
Console.WriteLine(monLepi);


*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapillonMeta
{
    public abstract class StadeEvolution
    {

        public StadeEvolution() { }
        public abstract string SeDeplacer();
        public abstract StadeEvolution SeMetamorphoser();
       

    }
}


