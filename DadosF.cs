using System;

namespace Funcionario
{
    public class DadosF
    {
        public string Nome;
        public double SalarioBruto;
        public double Desconto;

        public DadosF(string nome, double salarioBruto, double desconto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Desconto = desconto;
        }

        public double CalcularSalarioLiquido()
        {
            return SalarioBruto - (SalarioBruto * Desconto / 100.0);
        }

        public double Bonus()
        {
            return SalarioBruto + (SalarioBruto * Desconto / 100.0);
        }

        public override string ToString()
        {
            double salarioLiquido = CalcularSalarioLiquido();
            double bonus = Bonus();
            return $"Nome: {Nome} \nSalário Bruto: {SalarioBruto} \nDesconto: {Desconto} %\nLíquido a receber: {salarioLiquido}\n" +
                   $"{Nome}, como o seu Bônus, chega ao salário de R$ {bonus}";
        }
    }
}
