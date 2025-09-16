// See https://aka.ms/new-console-template for more information
int numero, i;
Console.WriteLine("Digite um número para obter seu fatorial (!).");
Console.WriteLine("Sabendo que fatorial negativo não existe.");
numero = int.Parse(Console.ReadLine());
int fatorial = 1;
for (i = 1;  i <= numero; i++)
{
    fatorial *= i;
}
Console.WriteLine($"O fatorial de {numero} é {fatorial}");

