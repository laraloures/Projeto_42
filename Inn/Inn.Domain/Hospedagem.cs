using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_42.Ordering.Ordering.Domain
{
    public class Hospedagem {

        public int codHospedagem { get; set; }
        public Chale chale { get; set; }
        public string estado { get; set; }
        public string dataInicio { get; set; }
        public string dataFim { get; set; }
        public int qtdPessoas { get; set; }
        public float desconto { get; set; }
        public float valorFinal { get; set; }
        public List<Servico> servicoHospedagem { get; set; }

        public Hospedagem() { }

        public Hospedagem(int codHospedagem, Chale chale, string estado = null, string dataInicio = null, string dataFim = null,
            int qtdPessoas = 0, float desconto = 0, float valorFinal = 0, List<Servico> servicoHospedagem = null) {
            this.codHospedagem = codHospedagem;
            this.chale = chale;
            this.estado = estado;
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
            this.qtdPessoas = qtdPessoas;
            this.desconto = desconto;
            this.valorFinal = valorFinal;
            this.servicoHospedagem = servicoHospedagem;
        }

        public bool podeHospedar() {
            return this.qtdPessoas <= chale.codChale;
        }
    }
}
