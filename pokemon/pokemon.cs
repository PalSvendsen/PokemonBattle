using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace pokemon
{
    public class pokemonNNN
    {
        public List<string> pokeList = new List<string>();
        private int Pokeballs;
        private int Potion;
        private int Credits = 100;
        public void Gress()
        {
            Pokemon[] GressPokemon = { new Pokemon { Name = "Bulbasaur", Health = RandomizeStat(), Strength = RandomizeStat() },
                new Pokemon { Name = "Oddish", Health = RandomizeStat(), Strength =  RandomizeStat() },
                new Pokemon { Name = "Bellsprout", Health = RandomizeStat(), Strength =  RandomizeStat() },
                new Pokemon { Name = "Tangela", Health = RandomizeStat(), Strength =  RandomizeStat() } };
            Random pokeRandom  = new Random();
            int pokeIndex = pokeRandom.Next(GressPokemon.Length);
            Pokemon pokeString = GressPokemon[pokeIndex];
            Console.WriteLine($"Du fant {pokeString.Name}. Han har {pokeString.Health}hp og {pokeString.Strength} styrke!");
            Console.WriteLine();
            Console.WriteLine("Hva vil du gjøre?");
            Console.WriteLine("1. Gå i kamp?");
            Console.WriteLine("2. Prøve å fange");

            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    Console.WriteLine("Du gikk i kamp!");
                    HandleBattle(GressPokemon[pokeIndex].Name);
                    break;
                case "2":
                    Console.WriteLine("Du prøver å fange Pokémon!");
                    HandleCatch(GressPokemon[pokeIndex].Name);
                    break;
                default:
                    Console.WriteLine("Ugyldig valg.");
                    break;
            }
        }

        public void Vann()
        {
            Pokemon[] VannPokemon =
            {
                new Pokemon { Name = "Squirtle", Health = RandomizeStat(), Strength = RandomizeStat() },
                new Pokemon { Name = "Todotile", Health = RandomizeStat(), Strength = RandomizeStat() },
                new Pokemon { Name = "Mudkip", Health = RandomizeStat(), Strength = RandomizeStat() },
                new Pokemon { Name = "Piplup", Health = RandomizeStat(), Strength = RandomizeStat() }
            };
            Random pokeRandom = new Random();
            int pokeIndex = pokeRandom.Next(VannPokemon.Length);
            Pokemon pokeString = VannPokemon[pokeIndex];
            Console.WriteLine($"Du fant {pokeString.Name}. Han har {pokeString.Health}hp og {pokeString.Strength} styrke!");
            Console.WriteLine();
            Console.WriteLine("Hva vil du gjøre?");
            Console.WriteLine("1. Gå i kamp?");
            Console.WriteLine("2. Prøve å fange");

            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    Console.WriteLine("Du gikk i kamp!");
                    HandleBattle(VannPokemon[pokeIndex].Name);
                    break;
                case "2":
                    Console.WriteLine("Du prøver å fange Pokémon!");
                    HandleCatch(VannPokemon[pokeIndex].Name);
                    break;
                default:
                    Console.WriteLine("Ugyldig valg.");
                    break;
            }
        }

        public void Hule()
        {
            Pokemon[] HulePokemon =
            {
                new Pokemon { Name = "Zubat", Health = RandomizeStat(), Strength = RandomizeStat() },
                new Pokemon { Name = "Geodude", Health = RandomizeStat(), Strength = RandomizeStat() },
                new Pokemon { Name = "Onix", Health = RandomizeStat(), Strength = RandomizeStat() },
                new Pokemon { Name = "Aron", Health = RandomizeStat(), Strength = RandomizeStat() }
            };
            Random pokeRandom = new Random();
            int pokeIndex = pokeRandom.Next(HulePokemon.Length);
            Pokemon pokeString = HulePokemon[pokeIndex];
            Console.WriteLine($"Du fant {pokeString.Name}. Han har {pokeString.Health}hp og {pokeString.Strength} styrke!");
            Console.WriteLine();
            Console.WriteLine("Hva vil du gjøre?");
            Console.WriteLine("1. Gå i kamp?");
            Console.WriteLine("2. Prøve å fange");

            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    Console.WriteLine("Du gikk i kamp!");
                    HandleBattle(HulePokemon[pokeIndex].Name);
                    break;
                case "2":
                    Console.WriteLine("Du prøver å fange Pokémon!");
                    HandleCatch(HulePokemon[pokeIndex].Name);
                    break;
                default:
                    Console.WriteLine("Ugyldig valg.");
                    break;
            }
        }

        public void Bakke()
        {
            Pokemon[] BakkePokemon =
            {
                new Pokemon { Name = "Sandshrew", Health = RandomizeStat(), Strength = RandomizeStat() },
                new Pokemon { Name = "Diglett", Health = RandomizeStat(), Strength = RandomizeStat() },
                new Pokemon { Name = "Phanpy", Health = RandomizeStat(), Strength = RandomizeStat() },
                new Pokemon { Name = "Trapinch", Health = RandomizeStat(), Strength = RandomizeStat() }
            };
            Random pokeRandom = new Random();
            int pokeIndex = pokeRandom.Next(BakkePokemon.Length);
            Pokemon pokeString = BakkePokemon[pokeIndex];
            Console.WriteLine($"Du fant {pokeString.Name}. Han har {pokeString.Health}hp og {pokeString.Strength} styrke!");
            Console.WriteLine();
            Console.WriteLine("Hva vil du gjøre?");
            Console.WriteLine("1. Gå i kamp?");
            Console.WriteLine("2. Prøve å fange");

            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    Console.WriteLine("Du gikk i kamp!");
                    HandleBattle(BakkePokemon[pokeIndex].Name);
                    break;
                case "2":
                    HandleCatch(BakkePokemon[pokeIndex].Name);
                    break;
                default:
                    Console.WriteLine("Ugyldig valg.");
                    break;
            }
        }

        private void HandleBattle(string pokemonName)
        {
            string[] fightOrFlight = { $"{pokemonName} rømte", $"{pokemonName} slår tilbake!" };
            Random FightOrFlight = new Random();
            int fightIndex = FightOrFlight.Next(fightOrFlight.Length);


            Console.WriteLine(fightOrFlight[fightIndex]);
        }

        private void HandleCatch(string pokemonName)
        {
            string[] caught = { $"Du fanget {pokemonName}!", $"{pokemonName} rømte!" };
            Random catchRandom = new Random();
            int catchIndex = catchRandom.Next(caught.Length);

            Console.WriteLine(caught[catchIndex]);

            if (caught[catchIndex] == $"Du fanget {pokemonName}!")
            {
                pokeList.Add(pokemonName);
            }
        }

        public void CoachInventory()
        {
            Console.WriteLine($"Du har {Potion} potion(s) and {Pokeballs} pokeball(s) and {Credits} credit(s) left!");
            foreach (var poke in pokeList)
            {
                Console.WriteLine($"-{poke}");
            }
        }
       public int RandomizeStat()
        {
            Random random = new Random();
            return random.Next(1, 200); 
        }

       public void PokeShop()
       {
           Console.WriteLine("Velkommen til PokeShop. Hva vil du ha?");
           Console.WriteLine("1. Pokeball cost: 30CR");
           Console.WriteLine("2. Potion cost: 40CR");

           string valg = Console.ReadLine();

           switch (valg)
           {
                case "1":
                    Pokeballs++;
                    Credits -= 30;
                    Console.WriteLine($"Du har kjøpt en pokeball. Du har nå {Pokeballs} pokeballs tilgjengelig");
                    break;
                case "2":
                    Potion++;
                    Credits -= 40;
                    Console.WriteLine($"Du har kjøp en potion. Du har nå {Potion} tilgjengelig");
                    break;
           }
       }
    }
    class Pokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
    }
}
