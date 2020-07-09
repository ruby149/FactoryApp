using System;
using System.Collections.Generic;
using System.Text;

namespace factoryApp
{
    public class GrassType : IPokemon
    {
        public GrassType()
        {

        }
        public void Type()
        {
            Console.WriteLine("The Pokemon is a water type");
            Console.WriteLine("This Pokemon has a weakness of water!");

        }
    }
}
