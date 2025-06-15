using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Produto para e-commerce de jogos

namespace Abstraction
{
    internal class Jogo
    {
        public string Titulo; // Título do jogo
        public string Plataforma; // Plataforma (PC, PS5, Xbox, etc.)
        public string Genero; // Gênero (Ação, Aventura, RPG, etc.)
        public string Desenvolvedor; // Desenvolvedor do jogo
        public DateTime DataLancamento; // Data de lançamento
        public double Preco; // Preço em reais
        public string Descricao; // Descrição do jogo
        public int Avaliacao; // Avaliação do jogo (1 a 5 estrelas)
    }
}
