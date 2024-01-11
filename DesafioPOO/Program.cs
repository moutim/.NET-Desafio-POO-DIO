using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone iPhone:");
Iphone iPhone = new(numero: "11998181280", modelo: "Xr", imei: "12345678", memoria: 128);
iPhone.ApresentarAparelho();
iPhone.Ligar("1144597825");
iPhone.InstalarAplicativo("Instagram");

Console.WriteLine("---------------------------");

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new(numero: "11944597825", modelo: "Lumia", imei: "87654321", memoria: 64);
nokia.ApresentarAparelho();
nokia.Ligar("11998181280");
nokia.InstalarAplicativo("WhatsApp");