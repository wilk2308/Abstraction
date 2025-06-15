using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Personagem para jogo RPG


namespace Abstraction
{
    internal class Personagem // Classe que representa um personagem em um jogo RPG
    {
        public string Nome; // Nome do personagem
        public string Classe; // Classe do personagem (guerreiro, mago, arqueiro, etc.)
        public int Nivel; // Nível do personagem
        public int Forca; // Atributo de força
        public int Agilidade; // Atributo de agilidade
        public int Inteligencia; // Atributo de inteligência
        public double Vida; // Pontos de vida
        public double Mana; // Pontos de mana
        public List<string> Habilidades; // Lista de habilidades do personagem
        public Personagem() // Construtor padrão
        {
            Habilidades = new List<string>(); // Inicializa a lista de habilidades
        }
    }
}
