namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        
        public override void ApresentarAparelho()
        {
            Console.WriteLine($"Nokia {ObterModelo()} com {ObterMemoria()}gb, número {Numero} e IMEI {ObterIMEI()}.");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Nokia {ObterModelo()}.");
        }
    }
}