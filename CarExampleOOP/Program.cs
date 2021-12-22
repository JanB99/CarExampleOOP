using System;

namespace CarExampleOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Eigenaar eigenaar = new Eigenaar("Pietje");
            eigenaar.garage.VoegToe(new Auto(2010, "rood", "Ford", 180));
            eigenaar.garage.VoegToe(new Boot(1998, "groen", "Coole Boot", 20));
            eigenaar.garage.VoegToe(new Boot(1950, "grijs", "Titanic", 400));
            eigenaar.garage.VoegToe(new Auto(2005, "geel", "BMW", 160));

            // Voor iedere voertuig in de lijst met voertuigen 
            // Toon info van het desbetreffende voertuig (polymorphism)
            foreach (Voertuig v in eigenaar.garage.voertuigen)
            {
                v.ToonInfo();
            }

            // Voor iedere voertuig in de lijst met voertuigen 
            // Roep StartMotor aan van het desbetreffende voertuig (polymorphism)
            foreach (Voertuig v in eigenaar.garage.voertuigen) 
            {
                v.StartMotor();
            }
        }
    }
}
