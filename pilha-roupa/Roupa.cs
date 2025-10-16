using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilha_roupa
{
    public class Roupa
    {
        public string Descricao { get; private set; }
        public string Cor { get; private set; }

        public Roupa ProximaRoupa { get; set; }

        public Roupa(string descricao, string cor)
        {
            this.Descricao = descricao;
            this.Cor = cor;
        }
    }
}
