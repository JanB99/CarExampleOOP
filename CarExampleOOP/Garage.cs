using System;
using System.Collections.Generic;
using System.Text;

namespace CarExampleOOP
{
    class Garage
    {
        public List<Voertuig> voertuigen;

        /// <summary>
        /// Constructor die de lijst met voertuigen initialiseert
        /// </summary>
        public Garage() {
            voertuigen = new List<Voertuig>();
        }

        /// <summary>
        /// Methode die een Voertuig object toevoegt aan de lijst met voertuigen
        /// </summary>
        /// <param name="nieuwVoertuig">Het nieuwe voertuig dat toegevoegt dient te worden</param>
        public void VoegToe(Voertuig nieuwVoertuig)
        {
            voertuigen.Add(nieuwVoertuig);
        }
    }
}
