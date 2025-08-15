//  Crie um programa que leia o código de um
//  produto (1 a 5) e exiba seu nome e preço

Console.WriteLine("LISTA DE PRODUTOS");
Console.WriteLine("Escolha o produto para consultar o preço.");
Console.WriteLine("1 - Arroz");
Console.WriteLine("2 - Feijão");
Console.WriteLine("3 - Macarrão");
Console.WriteLine("4 - Molho de tomate");
Console.WriteLine("5 - Bife de fígado");
int opcao = Convert.ToInt32(Console.ReadLine());
switch (opcao)
{
    case 1:
        Console.WriteLine("Arroz 5kg: R$25,98");
        break;
    case 2:
        Console.WriteLine("Feijão 1kg: R$15,90");
        break;
    case 3:
        Console.WriteLine("Macarrão 500g - R$3,49");
        break;
    case 4:
        Console.WriteLine("Molho de tomate 250g - R$2,98");
        break;
    case 5:
        Console.WriteLine("Bife de fígado kg - R$18,90");
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}