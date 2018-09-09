using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_42.Ordering.Ordering.Domain
{
    public class Cliente {
        public int codCliente { get; set; }
        public string nomeCliente { get; set; }
        public string rgCliente { get; set; }
        public string enderecoCliente { get; set; }
        public string bairroCliente { get; set; }
        public string cidadeCliente { get; set; }
        public string estadoCliente { get; set; }
        public string nascimentoCliente { get; set; }
        public List<Telefone> telefoneCliente { get; set; }

        public Cliente(int codCliente, string nomeCliente = "NomeDefault", string rgCliente = "RG", string enderecoCliente = "EndDefault",
            string bairroCliente = "bairroDefault", string cidadeCliente = "cidadeDefault", string estadoCliente = "estadoDefault",
            string nascimentoCliente = "00/00/0000", List<Telefone> telefoneCliente = null) { 
            this.codCliente = codCliente;
            this.nomeCliente = nomeCliente;
            this.rgCliente = rgCliente;
            this.enderecoCliente = enderecoCliente;
            this.bairroCliente = bairroCliente;
            this.cidadeCliente = cidadeCliente;
            this.enderecoCliente = estadoCliente;
            this.nascimentoCliente = nascimentoCliente;
            this.telefoneCliente = telefoneCliente;
        }
    }
}
