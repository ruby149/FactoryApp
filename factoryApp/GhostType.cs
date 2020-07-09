using System;
using System.Collections.Generic;
using System.Text;

namespace factoryApp
{
    public class GhostType : IPokemon

    {
        public GhostType()
        {

        }
        public void Type()
        {
            Console.WriteLine("The Pokemon is a ghost type");
            Console.WriteLine("This Pokemon is new!");

        }
    }
}
