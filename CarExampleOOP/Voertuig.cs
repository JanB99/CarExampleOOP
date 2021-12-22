using System;
using System.Collections.Generic;
using System.Text;

namespace CarExampleOOP
{
    // "abstract" keyword plaatsen voor de class naam om de class abstract te maken
    // dit betekent dat men geen instanties van de class Voertuig kan maken, maar wel instanties van de subklasses van voertuig kan maken (auto/boot)
    abstract class Voertuig
    {
        // De eigenschappen van de Voertuig class
        public int bouwjaar;
        public string kleur;
        public string merk;

        /// <summary>
        /// Constructor methode
        /// </summary>
        /// <param name="bouwjaar">1ste argument; bouwjaar van het voertuig</param>
        /// <param name="kleur">2de argument; kleur van het voertuig</param>
        /// <param name="merk">3de argument; merk van het voertuig</param>
        public Voertuig(int bouwjaar, string kleur, string merk) {
            this.bouwjaar = bouwjaar;
            this.kleur = kleur;
            this.merk = merk;
        }

        /// <summary>
        /// Abstracte methode die je alleen kan aanroepen in de subclasses van de Voertuig class
        /// </summary>
        public abstract void StartMotor();
        public abstract void ToonInfo();
    }
}
