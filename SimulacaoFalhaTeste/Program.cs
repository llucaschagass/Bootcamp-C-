using System;
// Solicite ao usuário que digite o nome do teste:
Console.Write("Digite o nome do teste: ");
string nomeDoTeste = Console.ReadLine();

// Solicite ao usuário que digite a descrição do erro:
Console.Write("Digite a descrição do erro: ");
string descricaoDoErro = Console.ReadLine();

// Exibe a mensagem de erro formatada:
Console.WriteLine($"O teste falhou. Descricao do erro: {descricaoDoErro}");
