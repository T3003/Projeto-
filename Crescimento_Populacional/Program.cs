using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira a população inicial: ");
        double populacaoInicial = double.Parse(Console.ReadLine());

        Console.Write("Insira a população final: ");
        double populacaoFinal = double.Parse(Console.ReadLine());

        Console.Write("Insira o tempo decorrido (em anos): ");
        double tempo = double.Parse(Console.ReadLine());

        double taxaDeCrescimento = Math.Pow(populacaoFinal / populacaoInicial, 1 / tempo) - 1;

        Console.WriteLine("A taxa de crescimento populacional é de {0:P2} ao ano.", taxaDeCrescimento);
    }
}
