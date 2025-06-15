using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pedido para sistema de restaurante

namespace Abstraction
{
    internal class Pedido
    {
        public string Cliente; // Nome do cliente
        public List<string> Itens; // Lista de itens do pedido
        public double ValorTotal; // Valor total do pedido
        public DateTime DataHora; // Data e hora do pedido
        public string Status; // Status do pedido (pendente, em preparo, entregue, cancelado)
        public string Descricao;
        // Construtor padrão
        public Pedido()
        {
            Itens = new List<string>(); // Inicializa a lista de itens
            ValorTotal = 0.0; // Inicializa o valor total como zero
            DataHora = DateTime.Now; // Define a data e hora atual
            Status = "pendente"; // Define o status inicial como pendente
        }
    }
}
