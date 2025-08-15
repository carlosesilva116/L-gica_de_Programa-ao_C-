//Criar um programa que solicite senha até que o 
//usuário digite a correta, usando do-while em C#.

string senha = "1234";
string senhadig;
do
{
    Console.WriteLine("Digite sua senha:");
    senhadig = (Console.ReadLine());
    if (senhadig != senha)
    {
        Console.WriteLine("Senha incorreta, tente novamente!");
    }
} while (senhadig != senha);
Console.WriteLine("Acesso liberado!");