using System;
using System.Collections.Generic;
using System.Text;

namespace CarExampleOOP
{
    // De Boot class erft alle properties en methoden over van de Voertuig class
    class Boot : Voertuig
    {

        public int aantalPassgiers;

        /// <summary>
        /// Constructor van de Boot klasse
        /// Gebruikt een aantal parameters om de constructor van de base klasse aan te roepen (Voertuig class)
        /// Na het aanroepen van de constructor van de base/parent class wordt de Auto constructor uitgevoerd
        /// </summary>
        /// <param name="bouwjaar"></param>
        /// <param name="kleur"></param>
        /// <param name="merk"></param>
        /// <param name="aantalPassgiers"></param>
        public Boot(int bouwjaar, string kleur, string merk, int aantalPassgiers)
            : base(bouwjaar, kleur, merk)
        {
            this.aantalPassgiers = aantalPassgiers;
        }

        /// <summary>
        /// Implementatie van de abstract method StartMotor, deze "overschrijft" als het ware de abstracte methode (die geen implementatie bevat)
        /// Hiermee wordt het concept van polymorphisme gerealiseerd, wat letterlijk betekent: 
        /// dat er meerdere (poly) vormen (morph) van types bestaan.
        /// In dit geval zijn er meerdere vormen van voertuigen, namelijk Auto's en Boten die hun eigen implementatie van StartMotor bevatten
        /// </summary>
        public override void StartMotor()
        {
            Console.WriteLine("... de motor van de boot is gestart en de boot vaart nu.");
        }

        public override void ToonInfo()
        {
            Console.WriteLine("--- Voertuig boot ---");
            Console.WriteLine($"\tBouwjaar: {bouwjaar}");
            Console.WriteLine($"\tMerk: {merk}");
            Console.WriteLine($"\tKleur: {kleur}");
            Console.WriteLine($"\tAantal passagiers: {aantalPassgiers}\n");
        }
    }
}
