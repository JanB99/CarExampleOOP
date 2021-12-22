using System;
using System.Collections.Generic;
using System.Text;

namespace CarExampleOOP
{
    // De Auto class erft alle properties en methoden over van de Voertuig class
    class Auto : Voertuig
    {
        public int maxSnelheid;

        /// <summary>
        /// Constructor van de Auto klasse
        /// Gebruikt een aantal parameters om de constructor van de base klasse aan te roepen (Voertuig class)
        /// Na het aanroepen van de constructor van de base/parent class wordt de Auto constructor uitgevoerd
        /// </summary>
        /// <param name="bouwjaar"></param>
        /// <param name="kleur"></param>
        /// <param name="merk"></param>
        /// <param name="maxSnelheid"></param>
        public Auto(int bouwjaar, string kleur, string merk, int maxSnelheid) 
            : base(bouwjaar, kleur, merk)
        {
            this.maxSnelheid = maxSnelheid;
        }

        /// <summary>
        /// Implementatie van de abstract method StartMotor, deze "overschrijft" als het ware de abstracte methode (die geen implementatie bevat)
        /// Hiermee wordt het concept van polymorphisme gerealiseerd, wat letterlijk betekent: 
        /// dat er meerdere (poly) vormen (morph) van types bestaan.
        /// In dit geval zijn er meerdere vormen van voertuigen, namelijk Auto's en Boten die hun eigen implementatie van StartMotor bevatten
        /// </summary>
        public override void StartMotor() 
        {
            Console.WriteLine("... de motor van de auto is gestart en de auto rijdt nu.");
        }

        public override void ToonInfo() {
            Console.WriteLine("--- Voertuig auto ---");
            Console.WriteLine($"\tBouwjaar: {bouwjaar}");
            Console.WriteLine($"\tMerk: {merk}");
            Console.WriteLine($"\tKleur: {kleur}");
            Console.WriteLine($"\tmaximale snelheid: {maxSnelheid}\n");
        }
    }
}
