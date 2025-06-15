using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// imóvel para sistema de aluguel

namespace Abstraction
{
    internal class Imovel
    {
        public string Tipo; // Tipo de imóvel (casa, apartamento, etc.)
        public string Endereco; // Endereço do imóvel
        public int Quartos; // Número de quartos
        public int Banheiros; // Número de banheiros
        public double Area; // Área em metros quadrados
        public bool MobiliaInclusa; // Se o imóvel vem mobiliado ou não
        public double ValorAluguel; // Valor do aluguel mensal em reais
        public string Descricao; // Descrição do imóvel
        public bool Disponivel; // Se o imóvel está disponível para aluguel ou não
    }
}
