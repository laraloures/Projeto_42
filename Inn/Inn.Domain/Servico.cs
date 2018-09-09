using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_42.Ordering.Ordering.Domain
{
    public class Servico {
        private int codServico { get; set; }
        private string nomeServico { get; set; }
        private float valorServico { get; set; }
        private string dataServico { get; set; }

        public Servico(int codServico, string nomeServico = "ServicoDefault", float valorServico = 0, string dataServico = "00/00/0000" ) {
            this.codServico = codServico;
        }
    }
}
