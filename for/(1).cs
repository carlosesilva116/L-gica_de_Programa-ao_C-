// Crie uma taboada com o número escolhido pelo usuário:

Console.WriteLine("Digite um número:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"você escolheu a taboada do: {num}");

for (int cont = 1; cont <= 10; cont++)
{
    Console.WriteLine($"{num} X {cont} = {num * cont}");
}