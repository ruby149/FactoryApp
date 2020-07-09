using System;
using System.Collections.Generic;
using System.Text;

namespace factoryApp
{
    public class WaterType : IPokemon
   
    {
        public WaterType()
        {

        }
        public void Type()
        {
            Console.WriteLine("The Pokemon is a water type");
            Console.WriteLine("This Pokemon has a weakness of grass!");

        }
    }
}
