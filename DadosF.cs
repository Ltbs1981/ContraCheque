using System;

namespace Funcionario
{
    public class DadosF
    {
        public string nome;
        public double salarioLiquido;
        public double desconto;
        double salarioBruto;
        double porcentagemDesconto;

        public DadosF(string nome, double salarioBruto, double porcentagemDesconto)
        {
            this.nome = nome;
            this.salarioBruto = salarioBruto;
            this.porcentagemDesconto = porcentagemDesconto;
        }

        public void CalcularSalarioLiquido()
        {
            desconto = salarioBruto * porcentagemDesconto;
            salarioLiquido = salarioBruto - desconto;
        }
    }
}
