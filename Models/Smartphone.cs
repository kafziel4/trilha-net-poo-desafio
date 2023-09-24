namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private readonly string _modelo;
        private readonly string _imei;
        private readonly int _memoria;

        public string Numero { get; set; }

        public Smartphone(string numero)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}