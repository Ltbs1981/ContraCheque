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

        public override string ToString()
        {
            double salarioLiquido = CalcularSalarioLiquido();
            return $"Nome: {Nome} \nSalário Bruto: {SalarioBruto} \nDesconto: {Desconto} \nLíquido a receber: {salarioLiquido}";
        }

        
        }
}
