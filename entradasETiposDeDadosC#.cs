using System;

namespace SimulacaoFalhaTeste {
  class Program {
    static void Main(string[] args) {
      string teste = Console.ReadLine();

      string descricaoDoErro = Console.ReadLine();

      // Se o teste falhar, exibe a descrição do erro:
      Console.WriteLine($"O teste falhou. Descricao: {descricaoDoErro}");
    }
  }
}
