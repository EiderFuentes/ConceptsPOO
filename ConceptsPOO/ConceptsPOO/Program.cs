
using ConceptsPOO;

Console.WriteLine("Concepts POO");
Console.WriteLine("==============");
Date date1 = new Date(2022, 2, 11);

//Console.WriteLine(date1);

// atajos 
// Ctrl + K + S saca el try y catch
try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(1974, 9, 23));
	Console.WriteLine(new Date(1985, 11, 30));
}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}