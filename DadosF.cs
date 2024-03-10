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

        
        public void CalcularSalarioLiquido()
        {
            desconto = salarioBruto * porcentagemDesconto;
            salarioLiquido = salarioBruto - desconto;
        }
    }
}
