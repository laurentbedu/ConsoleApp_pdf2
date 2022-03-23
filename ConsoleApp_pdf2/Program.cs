
ConsoleApp_pdf2.Vehicle v1 = new ConsoleApp_pdf2.Vehicle("Opel");
ConsoleApp_pdf2.Vehicle v2 = new ConsoleApp_pdf2.Vehicle("Blue", "Renault");
v1.GetDescription();
v2.GetDescription();

ConsoleApp_pdf2.Car c1 = new ConsoleApp_pdf2.Car();
ConsoleApp_pdf2.Boat b1 = new ConsoleApp_pdf2.Boat();
c1.Move(100);
v1.Move(1000);
b1.Move(10);

Console.ReadLine();
