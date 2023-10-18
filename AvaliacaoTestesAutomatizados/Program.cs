using System;

namespace AvaliacaoTestesAutomatizados {
  class Program {
    static void Main(string[] args) {
      // Solicita ao usuário a entrada para o número de testes passados
      Console.Write("Digite o número de testes automatizados bem-sucedidos: ");
      int testesPassados = Convert.ToInt32(Console.ReadLine());

      // Solicita ao usuário a entrada para o número total de testes
      Console.Write("Digite o número total de testes automatizados realizados: ");
      int totalTestes = Convert.ToInt32(Console.ReadLine());

      // Calcula a taxa de sucesso
      double taxaSucesso = (double)testesPassados / totalTestes * 100;

      // Exibe a taxa de sucesso com 2 casas decimais
      Console.WriteLine($"Taxa de sucesso: {taxaSucesso:F2}%");
    }
  }
}
