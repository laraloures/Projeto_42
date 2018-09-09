using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_42.Ordering.Ordering.Domain
{
    public class Chale {
        public int codChale { get; set; }
        public string localizacao { get; set; }
        public int capacidade { get; set; }
        public float valorAltaEstacao { get; set; }
        public float valorBaixaEstacao { get; set; }
        public List<Item> itemChale { get;set; }

        public Chale(int codChale, string localizacao = "LocalizacaoDefault", int capacidade = 0, float valorAltaEstacao = 0, 
            float valorBaixaEstaca = 0, List<Item> itemChale = null){
            this.codChale = codChale;
            this.localizacao = localizacao;
            this.capacidade = capacidade;
            this.valorAltaEstacao = valorAltaEstacao;
            this.valorBaixaEstacao = valorBaixaEstacao;
            this.itemChale = itemChale;
        }
    }
}
