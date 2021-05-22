using PagamentoFuncionario.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace PagamentoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Funcioãrios Vão Receber?");
            int qnt = int.Parse(Console.ReadLine());

            List<Funcionario> funcionario = new List<Funcionario>();

            for (int i = 1; i <= qnt; i++)
            {
                Console.Write("Nome Funcionário: ");
                string nome = Console.ReadLine();
                Console.Write("E Funcionário Tercerizado (Sim -> y /Não -> n)");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Quantidade de Hora Trabalhada: ");
                int qthora = int.Parse(Console.ReadLine());
                Console.Write("Valor Hora: ");
                double valhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipo == 'y')
                {
                    Console.Write("Quantidade de Hora Extra: ");
                    int horaextra = int.Parse(Console.ReadLine());
                    double valorhoraextra = 1.1 * horaextra;
                    funcionario.Add(new FuncionarioTercerizado(nome, qthora, valhora, valorhoraextra));
                }
                else
                {
                    funcionario.Add(new Funcionario(nome, qthora, valhora));
                }
            }
            foreach (Funcionario fun in funcionario)
            {
                Console.WriteLine(fun.Nome + " Recebeu de Pagamento - $" + fun.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
