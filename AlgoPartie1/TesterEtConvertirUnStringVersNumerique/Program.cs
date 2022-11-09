// See https://aka.ms/new-console-template for more information



// Tester ET CONVERTIR UN STRING VERS UN NUMERIQUE

String userInput = "toto";
double result;

result = double.Parse(userInput); // lève une exception si la conversion échoue 
result = Convert.ToDouble(userInput); // lève une exception si la conversion écoue

// ne lève pas d'exception et renvoie "false" en cas d'échec

bool isNumeric = double.TryParse(userInput, out result);
