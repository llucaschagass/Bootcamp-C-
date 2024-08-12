using System;

namespace VerificacaoDadosTeste {
  class Program {
    static void Main(string[] args) {
      // Aqui é solicitado ao usuário que insira o ID do teste:
      Console.WriteLine("Insira o ID do teste: ");
      int idTeste;
      if (int.TryParse(Console.ReadLine(), out idTeste)) {
        // Solicita ao usuário que insira a descrição do teste:
        Console.WriteLine("Insira a descricao do teste: ");
        string descricaoTeste = Console.ReadLine();

        // Inicialmente, consideramos que ambos o ID e descrição são inválidos
        bool idValido = false;
        bool descricaoValida = false;

        // Verifica se o ID do teste é válido
        if (idTeste > 0) {
          idValido = true;
        }

        // Verifica se a descrição está dentro dos limites
        if (descricaoTeste.Length <= 50) {
          descricaoValida = true;
        }

        // Verifica se o ID e a descrição são válidos e exibe mensagens apropriadas
        if (idValido && descricaoValida) {
          Console.WriteLine("ID de teste valido.");
          Console.WriteLine("Descricao valida.");
        } else {
          if (!idValido && !descricaoValida) {
            Console.WriteLine("ID de teste invalido e descricao muito longa.");
          } else if (!idValido) {
            Console.WriteLine("ID de teste invalido.");
          } else {
            Console.WriteLine("ID de teste invalido ou descricao muito longa.");
          }
        }
      } else {
        Console.WriteLine("ID de teste invalido.");
      }
    }
  }
}
