// See https://aka.ms/new-console-template for more information
double numero;
Console.WriteLine("Escreva um valor que direi se ele é negativo ou positivo (Sem ser 0).");
numero = double.Parse(Console.ReadLine());
if (numero > 0)
{
    Console.WriteLine("Seu número é POSITIVO.");
}
else
{
    Console.WriteLine("Seu número é NEGATIVO.");
}
