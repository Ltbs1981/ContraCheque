namespace Funcionario
{
    public class DadosF
    {
        public string nome;
        public double salarioBruto;
        public double desconto;

        public static double CalcularSalarioLiquido(double salarioBruto, double porcentagemDesconto)
        {
            double desconto = salarioBruto * porcentagemDesconto;
            return salarioBruto - desconto;
        }

        public static double AumentarSalario(double salarioBruto, double porcentagemAumento)
        {
            double aumento = salarioBruto * porcentagemAumento;
            return salarioBruto + aumento;
        }
    }
}
