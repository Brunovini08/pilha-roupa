using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilha_roupa
{
    public class Pilha
    {
        Roupa Head { get; set; }

        public Pilha()
        {
            Roupa head = Head;
        }

        public void Empilha(Roupa roupa)
        {
            if(this.Vazia())
            {
                this.Head = roupa;
            } else
            {
                roupa.ProximaRoupa = this.Head;
                this.Head = roupa;
            }
        }

        public Roupa Desempilha()
        {
            if(this.Vazia())
            {
                return null;
            } else
            {
                Roupa aux = this.Head;
                this.Head = this.Head.ProximaRoupa;
                if(this.Head == null)
                {
                    this.Head = null;
                }
                return aux;
            }
        }

        public bool Vazia()
        {
            if (Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Exibir()
        {
           if(this.Vazia())
            {
                Console.WriteLine("Pilha vazia!");
            } else
            {
                Roupa aux = this.Head;
                do
                {
                    Console.WriteLine($"Roupa: {aux.Descricao} - Cor: {aux.Cor}");
                    aux = aux.ProximaRoupa;
                } while (aux != null);
            }
        }
    }
}
