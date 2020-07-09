using System;

namespace factoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonNumber;
            bool input = false;

            do
            {
                Console.WriteLine("Enter the pokemonnumber of the Pokemon you want to train");
                 input = int.TryParse(Console.ReadLine(), out pokemonNumber);
            }
            while (!input);
            var Pokemon =Training.GetPokemon(pokemonNumber);
            Pokemon.Type();
            {

            }
        }
    }
}
