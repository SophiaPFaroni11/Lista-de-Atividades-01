// See https://aka.ms/new-console-template for more information
int numero1, numero2;
Console.WriteLine("Digite o 1º número.");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o 2º número.");
numero2 = int.Parse(Console.ReadLine());
if(numero1 > numero2)
{
    Console.WriteLine($"O seu maior número é {numero1}");
}
else
{
    Console.WriteLine($"O seu maior número é {numero2}");
}
