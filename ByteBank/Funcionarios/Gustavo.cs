using System;

namespace ByteBank.Funcionarios
{
    public class Gustavo : Funcionario
    {

        public Gustavo(string cpf) : base(6500, cpf)
        {
           
        }

        public override void AumentarSalario()
        {
            Salario *= 1.20;
        }

        public override double GetBonificacao()
        {
            return Salario *= 1.30;
        }
    }
}
