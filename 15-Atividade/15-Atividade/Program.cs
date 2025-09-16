// See https://aka.ms/new-console-template for more information
int numero;
Console.WriteLine("mostramos o número de 1.000 a 2.000");
for (int contador = 1000; contador<= 2000; contador++)
{
    if (contador % 11 ==5)
    {
        Console.WriteLine($"{contador}");
    }
}
