// See https://aka.ms/new-console-template for more information
int numero, resultado, quantidade;
Console.WriteLine("Digie o último numero");
numero = int.Parse(Console.ReadLine());
Console.WriteLine($"Os números de 1 a {numero} são:");
int contador = 1;
while (contador <= numero)
{
    Console.WriteLine($"{contador}");
    contador++;
}
