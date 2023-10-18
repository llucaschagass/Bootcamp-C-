using System;

namespace AnaliseDadosTeste {
  class Program {
    static void Main(string[] args) {
      // Solicita ao usuário a quantidade de testes bem-sucedidos:
      Console.Write("Digite a quantidade de testes bem-sucedidos: ");
      int testesBemSucedidos = int.Parse(Console.ReadLine());

      // Solicita ao usuário a quantidade de testes totais:
      Console.Write("Digite a quantidade total de testes realizados: ");
      int testesTotais = int.Parse(Console.ReadLine());

      // Calcula a taxa de sucesso
      double taxaSucesso = (double)testesBemSucedidos / testesTotais * 100;

      // Implementa uma estrutura condicional para avaliar a taxa de sucesso
      if (taxaSucesso >= 80) {
        Console.WriteLine("A funcionalidade esta pronta para lancamento.");
      } else {
        Console.WriteLine("A funcionalidade nao esta pronta para lancamento.");
      }
    }
  }
}
