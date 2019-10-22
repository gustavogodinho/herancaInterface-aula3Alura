using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
            guilherme.Nome = "Guilherme";

            Gustavo gustavo = new Gustavo("366.045.127-28");
            gustavo.Nome = "Gustavo Godinho";

          

            List<Funcionario> funcionarios = new List<Funcionario>
            {
                gustavo,
                guilherme,
                pedro,
                roberta,
                igor,
                camila
            };

            foreach (var item in funcionarios)
            {
                gerenciadorBonificacao.Registrar(item);
                Console.WriteLine(item.GetHashCode() + " " + item.Nome.PadRight(20,' ') + " " + 
                    item.CPF + " " + item.Salario.ToString("F",CultureInfo.InvariantCulture));
            }

            Console.WriteLine("-");
            Console.WriteLine("Total de bonificações do mês " +
            gerenciadorBonificacao.GetTotalBonificacao());

            Console.WriteLine("Total de Funcionarios " + Funcionario.TotalDeFuncionarios);

        }
    }
}