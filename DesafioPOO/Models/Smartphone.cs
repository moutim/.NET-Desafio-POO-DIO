namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar(string numero)
        {
            Console.WriteLine($"Ligando para o número {numero}...");
        }

        public void ReceberLigacao(string numero)
        {
            Console.WriteLine($"Recebendo ligação do número {numero}...");
        }

        public string ObterModelo(string modeloSmartphone)
        {
            return Modelo;
        }

        public string ObterIMEI(string modeloSmartphone)
        {
            return IMEI;
        }

        public int ObterMemoria(string modeloSmartphone)
        {
            return Memoria;
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}