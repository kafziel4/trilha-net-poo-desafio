using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "98888-8888", modelo: "C12", imei: "111111-11-111111-1", memoria: 64);
Smartphone iphone = new Iphone(numero: "97777-7777", modelo: "15 Pro", imei: "222222-22-222222-2", memoria: 128);

Console.WriteLine("Smartphone Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
