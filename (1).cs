// Crie um programa que leia dois números e mostre o maior entre eles.
 
Console.WriteLine("Digite o primeiro numero");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"O número {num1} é maior do que {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"O número {num2} é maior do que {num1}");
}
else
{
    Console.WriteLine("Os dois números são iguais");
}