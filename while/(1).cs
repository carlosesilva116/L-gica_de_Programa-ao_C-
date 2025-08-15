//Criar um programa que receba as idades digitadas até que o usuário digite uma negativa
//ao final, mostrar a média das idades digitadas.

int cont = -1;
double idade = 0;
double soma = 0;

while (idade >= 0)
{
    soma += idade;
  
    Console.WriteLine("Digite uma idade para acumular: ");
    idade = Convert.ToDouble(Console.ReadLine());
    cont++;
}

double media = soma / cont;

Console.WriteLine($"A média das idades é de: {media}");
