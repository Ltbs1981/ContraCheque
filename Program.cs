using System;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contra Cheque ");
            Console.WriteLine("Nome funcionário?");
            string nome = Console.ReadLine();
            Console.WriteLine($"Informe o salário bruto de {nome}");
            double salarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a porcentagem a ser descontada do salário para o IRRF");
            double porcentagemDesconto = double.Parse(Console.ReadLine()) / 100;

            DadosF funcionario = new DadosF(nome, salarioBruto, porcentagemDesconto);

            funcionario.CalcularSalarioLiquido();

            Console.WriteLine($"Nome: {funcionario.nome}");
            Console.WriteLine($"Desconto em folha: {funcionario.desconto}");
            Console.WriteLine($"Salário líquido: {funcionario.salarioLiquido}");
        }
    }
}
