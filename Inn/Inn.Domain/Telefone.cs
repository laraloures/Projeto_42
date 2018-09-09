using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_42.Ordering.Ordering.Domain
{
    public class Telefone{
        public string telefone { get; set; }
        public int codCliente { get; set; }
        public string tipoTelefone { get; set; }

        public Telefone(string telefone, int codCliente, string tipoTelefone = "tipoDefault") {
            this.codCliente = codCliente;
            this.telefone = telefone;
            this.tipoTelefone = tipoTelefone;
        }
    }
}
