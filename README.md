# 💎 Abstraction - Exercício de POO com C#

Este projeto é um exercício prático de **Programação Orientada a Objetos (POO)** em C#, com foco no pilar da **Abstração**. A ideia é representar objetos do mundo real e digital por meio de classes, atributos e instâncias.

## 💡 Objetivo

Simular diferentes contextos de aplicação — como imóveis, personagens de RPG, pedidos de restaurante, jogos e celulares — utilizando classes e abstrações para representar entidades reais.

---

## 📦 Classes Criadas

### 🏡 Imóvel

Classe que representa um imóvel para aluguel:

```csharp
public string Tipo;
public string Endereco;
public int Quartos;
public int Banheiros;
public double Area;
public bool MobiliaInclusa;
public double ValorAluguel;
public string Descricao;
public bool Disponivel;
```

---

### 🧙 Personagem

Classe que representa um personagem em um RPG:

```csharp
public string Nome;
public string Classe;
public int Nivel;
public int Forca;
public int Agilidade;
public int Inteligencia;
public double Vida;
public double Mana;
public List<string> Habilidades;

public Personagem() {
    Habilidades = new List<string>();
}
```

---

### 🍽️ Pedido

Classe que representa um pedido em um sistema de restaurante:

```csharp
public string Cliente;
public List<string> Itens;
public double ValorTotal;
public DateTime DataHora;
public string Status;
public string Descricao;

public Pedido() {
    Itens = new List<string>();
    ValorTotal = 0.0;
    DataHora = DateTime.Now;
    Status = "pendente";
}
```

---

### 🎮 Jogo

Classe que representa um produto em uma loja de jogos:

```csharp
public string Titulo;
public string Plataforma;
public string Genero;
public string Desenvolvedor;
public DateTime DataLancamento;
public double Preco;
public string Descricao;
public int Avaliacao;
```

---

### 📱 Celular

Classe que representa um celular em um e-commerce:

```csharp
public string Marca;
public string Modelo;
public string Cor;
public string Processador;
public int MemoriaRam; // em GB
public int Armazenamento; // em GB
public double TamanhoTela; // em polegadas
public int Bateria; // em mAh
public string SistemaOperacional;
public double Preco; // em reais
```

---

## 📁 Estrutura do Projeto

- `Program.cs`: ponto de entrada, com exemplos de instância
- `Imovel.cs`
- `Personagem.cs`
- `Pedido.cs`
- `Jogo.cs`
- `Celular.cs`

---

## 🚀 Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/wilk2308/AbstractionPOO.git
   ```
2. Abra o projeto no Visual Studio.
3. Compile e execute com `Ctrl + F5`.

---

## 🧠 Aprendizados

Este exercício reforça os seguintes conceitos de POO:

- ✅ Abstração
- ✅ Organização modular com classes
- ✅ Uso de construtores
- ✅ Tipos primitivos e compostos
- ✅ Instanciação de objetos

---

## ✍️ Autor

Desenvolvido por [William Gomes](https://github.com/wilk2308) como parte de seus estudos em Programação Orientada a Objetos com C#.

---