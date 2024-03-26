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
            double desconto = double.Parse(Console.ReadLine());

            DadosF funcionariio = new DadosF(nome, salarioBruto, desconto);

            Console.WriteLine(funcionariio.ToString());
            
        }
    }
}