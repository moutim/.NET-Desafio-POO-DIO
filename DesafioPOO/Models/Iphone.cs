namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void ApresentarAparelho(string modelo, string numero, string imei, int memoria)
        {
            Console.WriteLine($"iPhone {modelo} com {memoria}gb, número {numero} e IMEI {imei}.");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp, string modelo)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no iPhone {modelo}.");
        }
    }
}