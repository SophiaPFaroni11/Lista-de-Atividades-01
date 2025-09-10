// See https://aka.ms/new-console-template for more information
double salario;
Console.WriteLine("Digite seu salário atual para obter 15% de aumento.");
salario = double.Parse(Console.ReadLine());
Console.WriteLine($"O salário atual é {salario * 1.15}");
