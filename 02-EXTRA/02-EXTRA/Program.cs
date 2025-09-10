// See https://aka.ms/new-console-template for more information
double altura, largura, area;
Console.WriteLine("Digite a ALTURA a parede.");
altura = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a LARGURA a parede.");
largura = int.Parse(Console.ReadLine());
area = largura * altura;
Console.WriteLine($"Você vai precisar de {area / 2} latas de tintas");

