// See https://aka.ms/new-console-template for more information
double dinheiro, dolar;
Console.WriteLine("Qual o valor presente em sua carteira?");
dinheiro = double.Parse(Console.ReadLine());
dolar = dinheiro / 3.45;
Console.WriteLine($"Você tem U${dolar} ");
