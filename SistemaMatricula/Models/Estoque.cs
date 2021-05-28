using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        public Setor Setor{ get; set; }

        public int SetorId { get; set; }

        public Estoque()
        {

        }

        public Estoque(int id, string nome, float preco, int quantidade, Setor setor, int setorId)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Setor = setor;
            SetorId = setorId;
        }

        /*public double TotalItem(float preco, int quantidade)
        {
            return preco * quantidade;
        }

        /*public double TotalEstoque(double totalItem)
        {
            List<TotalItem> lista = new

            for (int i = 0; i < totalItem, i++)
            {
                resultado += totalItem[i];
            }

            return resultado;
            
        }*/
    }

    
}
