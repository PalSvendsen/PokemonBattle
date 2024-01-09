using pokemon;

namespace PokemonNew
{
    class Program
    {
        static void Main()
        {
            pokemonNNN newPokemon = new pokemonNNN();
            var pokeList = new List<string>();

            Console.WriteLine("Velkommen til Pokemon app. Hva er navnet på Pokemon treneren?");
            string trener = Console.ReadLine();
            Console.WriteLine("Hva er din start pokemon?");
            Console.WriteLine("1. Pikachu");
            Console.WriteLine("2. Charmander");
            Console.WriteLine("3. Vulp");
            string pokemon = Console.ReadLine().ToLower();
            if (pokemon != "pikachu" && pokemon != "charmander" && pokemon != "vulp")
            {
                Console.WriteLine("Try again");
                Main();
            }
            else
            {
                Console.WriteLine($"Velkommen {trener}, du har valgt {pokemon} som din start pokemon!");
            }
            //Console.WriteLine($"Velkommen {trener}, du har valgt {pokemon} som din start pokmenon!");
            pokeList.Add(pokemon);
            while (true)
            {
            Console.WriteLine("Hvor vil du lete etter pokemon?");
            Console.WriteLine("1. Gress");
            Console.WriteLine("2. Vann");
            Console.WriteLine("3. Hule");
            Console.WriteLine("4. Bakke");
            Console.WriteLine("5. Inventory");
            Console.WriteLine("6. Pokeshop");

            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    newPokemon.Gress();
                    break;
                case "2":
                    newPokemon.Vann(); 
                    break;
                case "3":
                    newPokemon.Hule();
                    break;
                case "4":
                    newPokemon.Bakke();
                    break;
                case "5":
                    newPokemon.CoachInventory();
                    break;  
                case "6":
                    newPokemon.PokeShop();
                    break;
                default:
                    Console.WriteLine("Ugyldig. Prøv igjen!");
                    break;
            }
        }
    }
}
}
