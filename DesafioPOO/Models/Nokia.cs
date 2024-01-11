namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        
        public override string ApresentarAparelho()
        {
            return $"Nokia {ObterModelo()} com {ObterMemoria()}gb, número {Numero} e IMEI {ObterIMEI()}.";
        }

        public override string InstalarAplicativo(string nomeApp)
        {
            return $"Instalando o aplicativo '{nomeApp}' no Nokia {ObterModelo()}.";
        }
    }
}