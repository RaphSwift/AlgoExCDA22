// 2e transformation papillon test programme




using MyPapillonMeta;

MyLepidoptere myLepi = new MyLepidoptere();
Console.WriteLine(myLepi.MySeDeplacer());
Console.WriteLine(myLepi);
myLepi.MySeMetamorphoser();
///  Stade Chenille
Console.WriteLine(myLepi.MySeDeplacer());
Console.WriteLine(myLepi);
myLepi.MySeMetamorphoser();
///  Stade Chrysalide
Console.WriteLine(myLepi.MySeDeplacer());
Console.WriteLine(myLepi);
myLepi.MySeMetamorphoser();
///  Stade Papillon
Console.WriteLine(myLepi.MySeDeplacer());
Console.WriteLine(myLepi);
myLepi.MySeMetamorphoser();
///  Stade Toujours un papillon
Console.WriteLine(myLepi.MySeDeplacer());
Console.WriteLine(myLepi);