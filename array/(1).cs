//Criei um vetor para armazenar nomes de 5 alunos.
//Criar outro vetor para armazenar médias desses alunos.
//no final, exibir cada aluno com sua respectiva média.


string[] alunos = new string[5];

for (int i = 0; i < alunos.Length; i++)
{
    Console.WriteLine($"Digite o nome do aluno {i + 1} :");
    alunos[i] = Convert.ToString(Console.ReadLine());
}
Console.Clear();

Double[] media = new double[5];

for (int i = 0; i < media.Length; i++)
{
    Console.WriteLine($"Digite a média do aluno{i + 1} :");
    media[i] = Convert.ToDouble(Console.ReadLine());
}
for (int i = 0; i < media.Length; i++)
{
    Console.WriteLine($"{alunos[i]} sua média é: {media[i]}");
}