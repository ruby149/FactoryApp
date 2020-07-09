using System;
using System.Collections.Generic;
using System.Text;

namespace factoryApp
{
    public static class Training 
    {
        public static IPokemon GetPokemon(int pokemonNumber)
        {
            switch (pokemonNumber)
            {
                case 2:
                    return new GrassType();
                case 3:
                    return new WaterType();
                case 4:
                    return new FireType();
                case 5:
                    return new GhostType();
                default:
                    return new GrassType();


            }
        }
    }
}
