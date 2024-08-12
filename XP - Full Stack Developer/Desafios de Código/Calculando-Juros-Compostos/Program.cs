using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Solicita ao usuário para inserir os valores
        double P = Convert.ToDouble(Console.ReadLine()); // Lê o valor principal P
        double i = Convert.ToDouble(Console.ReadLine()); // Lê a taxa de juros i
        int n = Convert.ToInt32(Console.ReadLine()); // Lê o número de anos n

        // Calcula o montante final utilizando a função CalcularJurosCompostos
        double montanteFinal = CalcularJurosCompostos(P, i, n);

        // Exibe o resultado
        Console.WriteLine(montanteFinal); // Mostra o montante final calculado
    }

    public static double CalcularJurosCompostos(double P, double i, int n)
    {
        // Calcula o montante final com juros compostos
        double montanteFinal = P * Math.Pow(1 + i, n);
        return montanteFinal;
    }
}
