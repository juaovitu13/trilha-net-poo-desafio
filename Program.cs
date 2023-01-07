using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "996710782", modelo: "Modelo 1", imei: "123456", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "99999999", modelo: "Modelo 2", imei: "789456", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");