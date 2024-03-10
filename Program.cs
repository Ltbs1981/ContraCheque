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

            double salarioLiquido = DadosF.CalcularSalarioLiquido(salarioBruto, porcentagemDesconto);

            Console.WriteLine($"Funcionário: {nome}. \n Desconto em folha: {porcentagemDesconto * 100}% \n Total líquido: {salarioLiquido}");

            Console.WriteLine($"\n Informe quantos % de aumento {nome} terá sobre seu salário bruto ");
            double porcentagemAumento = double.Parse(Console.ReadLine()) / 100;

            double salarioComAumento = DadosF.AumentarSalario(salarioBruto, porcentagemAumento);

            Console.WriteLine($"Funcionário: {nome}. \n Bônus: {porcentagemAumento * 100}% \n Salário Bruto + aumento: {salarioComAumento}");
        }
    }
}
