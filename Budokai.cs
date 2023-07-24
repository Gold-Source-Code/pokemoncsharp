using System;

class Budokai
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What's your name?");
        string? answer_trainername1 = Console.ReadLine();
        if(answer_trainername1 == null){
          answer_trainername1 = "N/A";
        }
        Console.WriteLine("What's your rival's name?");
        string? answer_trainername2 = Console.ReadLine();
        if(answer_trainername2 == null){
          answer_trainername2 = "N/A";
        }

        Trainer trainer1 = new Trainer(answer_trainername1);
        Trainer trainer2 = new Trainer(answer_trainername2);

        Console.WriteLine("What do you want to call your Charmander?");
        string? answer_pokemonname = Console.ReadLine();
        if(answer_pokemonname == null){
          answer_pokemonname = "N/A";
        }
      
        Console.WriteLine("Which Pokemon do you want to pull out?");
        string? PokeballIndexAsk = Console.ReadLine();
        int PokeballIndex = Convert.ToInt32(PokeballIndexAsk);
        if(PokeballIndexAsk == null){
          PokeballIndex = 0;
          }
        else{
          PokeballIndex = PokeballIndex - 1;
          }
        
        trainer1.AddToBelt(new Pokeball(new Charmander(answer_pokemonname, "Fire", "Water")), PokeballIndex);


        for x in i{
          
        }
        // for loop : belt { loop door belt heen en pak de pokeballs en gebruik dan de code hieronder in de loop.

        Console.WriteLine(trainer1.getTrainerName() + " VS. " + trainer2.getTrainerName());
        Console.WriteLine(PokeballIndex);
        Console.WriteLine("You pulled out " + trainer1.PokeBelt[PokeballIndex].GetPokemon().getName());
        Console.WriteLine("===============");
        Console.WriteLine(Pokeball1.GetPokemon().getName());
        Console.WriteLine(Pokeball1.GetPokemon().getStrength());
        Console.WriteLine(Pokeball1.GetPokemon().getWeakness());
        Console.WriteLine("===============");
        string? answer1 = "y";
      while (answer1 == "y"){
        Console.WriteLine("Use Growl? [Y/N]");
          answer1 = Console.ReadLine().ToLower();
            if (answer1 == "y"){
              for (int i = 0; i < 10; i++){
                Console.WriteLine(charmander.Growl());
                }
            }
        else{
          Console.WriteLine(charmander.getName() + " was returned to Pokeball " + (PokeballIndex + 1));
        }
      }
    }
}