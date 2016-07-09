/*
 * Author: Dilakshan Packiyanathan
 * Student # : 300843256
 * Date Modified: July 8th, 2016
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("======================================================");
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 4578356, 452145685, "Gas");
            Console.WriteLine(giantPlanet.ToString());
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 78238625, 5478564, true);           
            Console.WriteLine(terrestrialPlanet.ToString());
            Console.WriteLine("======================================================");
            Console.ReadLine();
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}
