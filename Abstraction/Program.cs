namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular
            {
                Marca = "Samsung",
                Modelo = "Galaxy S21",
                Cor = "Preto",
                Processador = "Exynos 2100",
                MemoriaRam = 8,
                Armazenamento = 128,
                TamanhoTela = 6.2,
                Bateria = 4000,
                SistemaOperacional = "Android 11",
                Preco = 4999.99
            };

            Console.WriteLine($"Marca: {celular.Marca}");
        }
    }
}
