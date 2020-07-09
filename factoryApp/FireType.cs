using System;
using System.Collections.Generic;
using System.Text;

namespace factoryApp
{
   
   public class FireType : IPokemon

    {
        public FireType()
        {

        }
        public void Type()
        {
            Console.WriteLine("The Pokemon is a fire type");
            Console.WriteLine("This Pokemon has a weakness of water!");
        }
    }
}
