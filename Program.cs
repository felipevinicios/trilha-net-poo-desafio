using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartohone Nokia: ");
Smartphone nokia = new Nokia (numero: "11970335014", modelo: "735", imei: "155515",memoria :16);
nokia.Ligar();
nokia.InstalarAplicativo("facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone: ");
Smartphone iphone = new Iphone (numero: "11945151856", modelo: "6s", imei:"698545",memoria:32);
iphone.Ligar();
iphone.InstalarAplicativo("whastsapp");
