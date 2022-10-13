using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Activity_2;

namespace Activity_2
{
    internal class Person
    {
        public DateTime FBase = new DateTime(2022, 09, 14);
        public int keyCode { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        List<License> Lic_List = new List<License>();
        List<Vehicle> Car_List = new List<Vehicle>();
        public bool Fraud = false;

        public bool P_Lic = true;

        public DateTime lastLicense { get; set; }

        private int Cont = 0;
        private int Num_Car = 0;

        public void licencere(License licenseMethod)
        {
            Lic_List.Add(licenseMethod);
        }
        public void receiveCar(Vehicle carMethod)
        {
            Car_List.Add(carMethod);
        }
        public bool E_Car(Vehicle Activity_2)
        {
            int i;

            foreach (Vehicle vehicle in Car_List)
            {
                if (Activity_2 == vehicle)
                {
                    Car_List.Remove(Activity_2);
                    return true;
                }

            }
            return false;
        }
        public int Car_Cont()
        {
            Num_Car = Car_List.Count;
            return Num_Car;
        }

        public bool validLicense()
        {
            for (int i = 0; i < Lic_List.Count; i++)
            {
                if (FBase < Lic_List[i].FFin)
                {
                    return true;
                }
            }

            return false;
        }

        public bool Val_Lic(string type)
        {
            for (int i = 0; i < Lic_List.Count; i++)
            {
                if (Lic_List[i].type == type)
                {

                    if (true == validLicense())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Person New_Per(int keyCode_N, string Name_N, string SurName_N, int Age_n, string Gender_N)
        {
            Person Per_Agr = new Person();
            Per_Agr.keyCode = keyCode_N;
            Per_Agr.name = Name_N;
            Per_Agr.surname = SurName_N;
            Per_Agr.age = Age_n;
            Per_Agr.gender = Gender_N;
            return Per_Agr;
        }


        public void Info(Person people)
        {
            Console.WriteLine("Key Code: " + people.keyCode + "\n" +
                "Name: " + people.name + "\n" +
                "LastName: " + people.surname + "\n" +
                "Age: " + people.age + "\n" +
                "Gender: " + people.gender + "\n");
        }
        public void Info_Lic()
        {
            Console.WriteLine("Licenses of " + name + "\n");
            Cont = 0;
            if (Lic_List.Count == 0)
            {
                Console.Write("No licenses" + "\n");
            }
            foreach (License license in Lic_List)
            {
                Cont++;
                Console.WriteLine("License Number: " + Cont + "\n" + "Type: " + license.type + "\n" + "Initial Date: " + license.FIni + "\n" + "Expiration date: " + license.FFin + "\n" + "Key code: " + license.key_Code + "\n");
            }
        }

        public void Info_Car()
        {
            Console.WriteLine("Cars of " + name + "\n");
            Cont = 0;
            if (Car_List.Count == 0)
            {
                Console.Write("No Cars" + "\n");
            }
            foreach (Vehicle car in Car_List)
            {
                Cont++;
                Console.WriteLine("Car Number " + Cont + "\n" + "Brand: " + car.brand + "\n" + "Year :" + car.year + "\n" + "Wheels: " + car.wheels + "\n" + "Color: " + car.color + "\n" + "Car type: " + car.type + "\n" + "Description: " + car.description + "\n");
            }
        }



        License date = new License();

        public void DarLic(License license)
        {
            if (age >= 90)
            {
                Console.WriteLine("Age limit exceeded, impossible to obtain a license" + "\n");
            }
            else
            {
                if (P_Lic == true)
                {
                    licencere(license);
                    license.key_Code = keyCode;
                    P_Lic = false;
                    lastLicense = license.FFin;
                }
                else
                {
                    if (lastLicense > date.FBase) 
                    {
                        Console.WriteLine("Impossible to activate a new license if you have an active license." + "\n");
                    }
                    else
                    {
                        licencere(license);
                        lastLicense = license.FFin;
                    }
                }

            }
        }

        public void DarCar(Vehicle car)
        {
            if (gender == "Girl")
            {
                if (car.color == "Red")
                {
                    receiveCar(car);
                }
                else
                {
                    Console.WriteLine("Women like only red vehicles" + "\n");
                }
            }
            else
            {
                if (car.brand == "Ford" || car.brand == "Toyota")
                {
                    receiveCar(car);
                }
                else
                {
                    Console.WriteLine("Men only accept vehicles of the brands Ford and Toyota" + "\n");
                }
            }
            if (Car_Cont() >= 5)
            {
                Fraud = true;
            }
        }
        public void Dev_Car(Vehicle car)
        {
            if (car.type == "A")
            {
                if (Val_Lic("A") == true)
                {
                    if (E_Car(car) == true)
                    {
                        Console.WriteLine("Car " + car.brand + " deleted to " + name + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Car " + car.brand + " didn't found on " + name + " to quit" + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("You need a valid license to cancel " + car.brand + "\n");
                }
            }
            else if (car.type == "B")
            {
                if (Val_Lic("B") == true)
                {
                    if (E_Car(car) == true)
                    {
                        Console.WriteLine("Car " + car.brand + " deleted to " + name + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Car" + car.brand + "didn't found on " + name + " to quit" + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("You need a valid license to cancel " + car.brand + "\n");
                }
            }

            else if (car.type == "C")
            {
                if (Val_Lic("C") == true)
                {
                    if (E_Car(car) == true)
                    {
                        Console.WriteLine("Car " + car.brand + " deleted to " + name + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Car" + car.brand + "didn't found on " + name + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("You need a valid license to cancel " + car.brand + "\n");
                }
            }
            else
            {
                Console.WriteLine("Inexistent car" + "\n");
            }



        }

    }
}