using System;
using System.Collections.Generic;
using System.Text;

namespace CarExampleOOP
{
    class Eigenaar
    {

        public string naam;
        public Garage garage;

        /// <summary>
        /// Constructor functie van eigenaar
        /// Initieert een object van het type "Garage"
        /// </summary>
        /// <param name="naam">Eigenaar naam die wordt toegekend aan de property naam</param>
        public Eigenaar(string naam) {
            this.naam = naam;
            garage = new Garage();
        }
    }
}
