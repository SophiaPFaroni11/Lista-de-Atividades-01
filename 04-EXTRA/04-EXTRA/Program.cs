// See https://aka.ms/new-console-template for more information
double preco;
Console.WriteLine("Digite o preço do produto para ganhar o deconto de 5%");
preco = double.Parse(Console.ReadLine());
Console.WriteLine($"O preço promocional é {preco * 0.95}");
