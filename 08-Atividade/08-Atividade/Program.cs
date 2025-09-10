// See https://aka.ms/new-console-template for more information
int numero;
Console.WriteLine("Escreva quantas maçãs foram compradas.");
numero = int.Parse(Console.ReadLine());
if (numero < 12)
{
    Console.WriteLine($"cada maçã custou R$ 1,30. E sua compra custou: {1.3*numero}");
}
else
{
    Console.WriteLine($"cada maçã custou R$ 1,00. E sua compra custou: {1 * numero}");
}
