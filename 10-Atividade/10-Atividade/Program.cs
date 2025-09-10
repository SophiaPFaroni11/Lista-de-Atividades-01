// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

double nota1, nota2, media;
Console.WriteLine("Escreva sua 1º Nota.");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Escreva sua 2º Nota.");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine($"Sua média foi: {media=(nota1+nota2)/2}");
if (media >= 6)
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("NÃO APROVADO");
}

