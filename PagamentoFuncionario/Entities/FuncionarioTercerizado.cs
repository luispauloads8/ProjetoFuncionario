using System;
using System.Collections.Generic;
using System.Text;

namespace PagamentoFuncionario.Entities
{
    class FuncionarioTercerizado : Funcionario
    {
        public double PercHorExtra { get; set; }

        public FuncionarioTercerizado()
        {
        }

        public FuncionarioTercerizado(string nome, int hora, double valorHora, double percHorExtra)
            : base(nome, hora, valorHora)
        {
            PercHorExtra = percHorExtra;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + PercHorExtra;
        }
    }
}
