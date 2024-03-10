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

            double desconto = CalcularSalarioLiquido(salarioBruto, porcentagemDesconto);
            double salarioLiquido = salarioBruto - desconto;

            Console.WriteLine($"Funcionário: {nome}. \n Desconto em folha: {desconto:f2}. \n Total líquido: {salarioLiquido:f2}");

            Console.WriteLine($"\n Informe quantos %de aumento {nome}, terá sobre seu salário bruto ");
            double porcentagemAumento = double.Parse(Console.ReadLine()) / 100;

            salarioBruto = AumentarSalario(salarioBruto, porcentagemAumento);

            Console.WriteLine($"Funcionário: {nome}. \n Bônus: {porcentagemAumento * 100}%. \n Salário Bruto + aumento: {salarioBruto}");
        }

        public static double CalcularSalarioLiquido(double salarioBruto, double porcentagemDesconto)
        {
            double desconto = salarioBruto * porcentagemDesconto;
            return desconto;
        }

        public static double AumentarSalario(double salarioBruto, double porcentagemAumento)
        {
            double aumento = salarioBruto * porcentagemAumento;
            salarioBruto += aumento;

            return salarioBruto;
        }
    }
}
