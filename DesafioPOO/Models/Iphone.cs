namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void ApresentarAparelho()
        {
            Console.WriteLine($"iPhone {ObterModelo()} com {ObterMemoria()}gb, número {Numero} e IMEI {ObterIMEI()}.");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no iPhone {ObterModelo()}.");
        }
    }
}