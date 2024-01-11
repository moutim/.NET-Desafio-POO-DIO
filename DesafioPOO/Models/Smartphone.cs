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

        public string Ligar(string numero)
        {
            return $"Ligando para o número {numero}...";
        }

        public string ReceberLigacao(string numero)
        {
            return $"Recebendo ligação do número {numero}...";
        }

        public string ObterModelo()
        {
            return Modelo;
        }

        public string ObterIMEI()
        {
            return IMEI;
        }

        public int ObterMemoria()
        {
            return Memoria;
        }

        public abstract string ApresentarAparelho();

        public abstract string InstalarAplicativo(string nomeApp);
    }
}