using DesafioPOO.Models;
Nokia celularNokia = new Nokia(numero: "(81) 999999999", modelo: "Nokia 6.1 Plus", imei: "356926095563124", memoria: 64);
Iphone celularIphone = new Iphone(numero: "(81) 999999999", modelo: "Iphone 14 Pro Max", imei: "331751428192825", memoria: 256);

//      NOKIA
Console.WriteLine("Celular Nokia\n");
celularNokia.Ligar();
celularNokia.InstalarAplicativo("Whatsapp");
celularNokia.ReceberLigacao();
Console.WriteLine($"Número antigo: {celularNokia.Numero}");
celularNokia.Numero = "(81) 900000000";
Console.WriteLine($"Número novo: {celularNokia.Numero}");

//
Console.WriteLine();
//

//      IPHONE
Console.WriteLine("Celular Iphone\n");
celularIphone.Ligar();
celularIphone.InstalarAplicativo("Instagram");
celularIphone.ReceberLigacao();
Console.WriteLine($"Número antigo: {celularIphone.Numero}");
celularIphone.Numero = "(81) 912345678";
Console.WriteLine($"Número novo: {celularIphone.Numero}");