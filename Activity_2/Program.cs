using Activity_2;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Vehicle Lobo = new Vehicle();Lobo.year = new DateTime(2022, 10, 11);Lobo.brand = "Ford";Lobo.wheels = "BlueRay";Lobo.color = "Black";Lobo.description = "Is very quick";Lobo.type = "A";

        Vehicle Altima = new Vehicle();Altima.year = new DateTime(2019, 07, 05);Altima.brand = "Nissan";Altima.wheels = "Luzu";Altima.color = "White";Altima.description = "Car for one person";Altima.type = "A";

        Vehicle Raptor = new Vehicle();Raptor.year = new DateTime(2007, 02, 15);Raptor.brand = "Ford";Raptor.wheels = "Mamey";Raptor.color = "Red";Raptor.description = "The car of evil";Raptor.type = "C";

        Vehicle March = new Vehicle();March.year = new DateTime(2015, 05, 12);March.brand = "Nissan";March.wheels = "AllTerrain";March.color = "Yellow";March.description = "Car of gold";March.type = "B";

        Vehicle Hilux = new Vehicle();Hilux.year = new DateTime(2012, 03, 01);Hilux.brand = "Toyota";Hilux.wheels = "Gempays";Hilux.color = "Red";Hilux.description = "Pistas de Blue";Hilux.type = "C";



        Person person = new Person();
        Person Per = person.New_Per(2721, "Marlen", "Diaz", 21, "Girl");

        Person Per1 = person.New_Per(0821, "Lucio", "Hernandez", 18, "Boy");

        Person Per2 = person.New_Per(6512, "Ana", "Rodriguez", 28, "Girl");

        Person Per3 = person.New_Per(7612, "Miguel", "Saucedo", 91, "Boy");

        Person Per4 = person.New_Per(9723, "Alexis", "Valles", 19, "Boy");

        Person Per5 = person.New_Per(2512, "Miriam", "Saucedo", 30, "Girl");



        License license = new License();
        License Lic1 = license.Make_Lic("A", new DateTime(2021, 05, 06), new DateTime(2022, 05, 06));

        License Lic3 = license.Make_Lic("A", new DateTime(2018, 12, 25), new DateTime(2023, 12, 25));

        License Lic4 = license.Make_Lic("C", new DateTime(2022, 08, 30), new DateTime(2023, 12, 25));

        Per1.DarCar(Raptor);
        Per5.DarCar(Hilux);
        Per5.DarCar(Hilux);
        Per5.DarCar(March);

        Per.DarLic(Lic1);
        Per.DarLic(Lic3);

        Per3.DarLic(Lic1);
        Per2.DarLic(Lic3);
        Per1.DarLic(Lic1);
        Per1.DarLic(Lic3);
        Per5.DarLic(Lic4);

        Per1.Dev_Car(Raptor);

        Console.WriteLine("DATAS");
        Console.WriteLine("\n\tUSER 1\n");person.Info(Per);Per.Info_Lic();Per.Info_Car();
        Console.WriteLine("\n\tUSER 2\n");person.Info(Per1);Per1.Info_Lic();Per1.Info_Car();
        Console.WriteLine("\n\tUSER 3\n");person.Info(Per2);Per2.Info_Lic();Per3.Info_Car();
        Console.WriteLine("\n\tUSER 4\n");person.Info(Per3);Per3.Info_Lic();Per3.Info_Car();
        Console.WriteLine("\n\tUSER 5\n");person.Info(Per4);Per4.Info_Lic();Per4.Info_Car();
        Console.WriteLine("\n\tUSER 6\n");person.Info(Per5);Per5.Info_Lic();Per5.Info_Car();

    }
}