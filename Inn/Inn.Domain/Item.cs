using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_42.Ordering.Ordering.Domain
{
    public class Item {
        public string nomeItem { get; set; }
        public string descricaoItem { get; set; }

        public Item(string nomeItem, string descricaoItem = "descricaoDefault") {
            this.nomeItem = nomeItem;
            this.descricaoItem = descricaoItem;
        }
    }
}
