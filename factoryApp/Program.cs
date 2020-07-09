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
                Console.WriteLine("Enter the pokemon number of the Pokemon you want to train");
                Console.WriteLine("Based on your number the pokemon you are going to train will appear and a few facts will also appear.");
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
