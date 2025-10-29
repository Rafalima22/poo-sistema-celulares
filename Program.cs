using DesafioPOO.Models;

//Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("34628", "Nokia Flip", "121212", 64);
nokia.ModeloCelular();
nokia.MemoriaCelular();
nokia.NumeroCelular();
nokia.IMEICelular();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("99854", "Iphone 16", "121415", 64);
iphone.ModeloCelular();
iphone.MemoriaCelular();
iphone.NumeroCelular();
iphone.IMEICelular();
iphone.InstalarAplicativo("Instagram");


