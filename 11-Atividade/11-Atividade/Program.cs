// See https://aka.ms/new-console-template for more information
int anoNascimento, anoAtual, idade;
Console.WriteLine("Escreva o ano do seu nascimento.");
anoNascimento = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o ano atual.");
anoAtual = int.Parse(Console.ReadLine());
idade = anoAtual - anoNascimento;
Console.WriteLine($"Você tem {idade}");
if (idade >= 18)
{
    Console.WriteLine("Você é obrigado(a) a VOTAR ESTE ANO.");
}
else if(idade <16)
{
    Console.WriteLine("Você não é obrigado(a) a VOTAR.");
}
else
{
    Console.WriteLine("Você pussui p voto FACULTATIVO.");
}

