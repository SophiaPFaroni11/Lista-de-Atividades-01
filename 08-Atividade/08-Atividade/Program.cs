// See https://aka.ms/new-console-template for more information
int numero;
Console.WriteLine("Escreva um numero diferente de 0");
numero = int.Parse(Console.ReadLine());
if (numero < 0)
{
    Console.WriteLine("Seu número é NEGATIVO");
}
else
{
    Console.WriteLine("Seu número é POSITIVO");
}
