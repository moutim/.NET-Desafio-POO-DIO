using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone iPhone:");
Iphone iPhone = new(numero: "11998181280", modelo: "Xr", imei: "12345678", memoria: 128);
iPhone.ApresentarAparelho(
    modelo: iPhone.ObterModelo(), 
    numero: iPhone.Numero,
    imei: iPhone.ObterIMEI(),
    memoria: iPhone.ObterMemoria()
);
iPhone.Ligar("1144597825");
iPhone.InstalarAplicativo("Instagram", iPhone.ObterModelo());

Console.WriteLine("---------------------------");

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new(numero: "11944597825", modelo: "Lumia", imei: "87654321", memoria: 64);
nokia.ApresentarAparelho(
    modelo: nokia.ObterModelo(), 
    numero: nokia.Numero,
    imei: nokia.ObterIMEI(),
    memoria: nokia.ObterMemoria()
);
nokia.Ligar("11998181280");
nokia.InstalarAplicativo("WhatsApp", nokia.ObterModelo());