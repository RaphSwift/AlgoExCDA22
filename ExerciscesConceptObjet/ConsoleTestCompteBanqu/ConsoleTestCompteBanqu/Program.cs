
using ClassLibrary;

CompteBancaire c1 = new CompteBancaire(12345, "toto", 1000, -500);
CompteBancaire c2 = new CompteBancaire(45678, "titi", 2000, -1000);

c1.CrediterMontant(100);
bool ok = c1.Debiter(1000);


bool resultat= c1.Transferer(1300, c2);


Console.WriteLine(c1.ToString());
Console.WriteLine(c2.ToString());



