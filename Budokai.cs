using System;
using System.Reflection;

class Budokai
{
    public static void Main(string[] args)
    {
    // Trainers get created.
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
    // Pokemons get added to belt.
        for (int i = 0; i < 2; i++){
          AskPokemon(trainer1);}
        for (int i = 0; i < 2; i++){
          AskPokemon(trainer2);}

    // Battle is made.
    Battle battle1 = new Battle(trainer1,trainer2);
    Arena arena1 = new Arena(trainer1,trainer2, battle1);
    // Scoreboard gets made.
    Arena.scoreboardcreate();
    arena1.battleloop("start"); 
    // PokeballIndex(2) are used to identify which pokemon is picked.
    // Growl loop.
      // battle.attackloop(trainer1, PokeballIndex, trainer2, PokeballIndex2);
    }
// Function creates pokemon, placed into PokeBelt List.
  static void AskPokemon(Trainer trainer){
      Console.WriteLine("What Pokemon would you like to add? 1. Squirtle 2. bulbasaur 3. charmander");
      string? Pokemon_type = Console.ReadLine();
      Console.WriteLine("What do you want to call your Pokemon?");
      string? answer_pokemonname = Console.ReadLine();
      if(answer_pokemonname == null){
        answer_pokemonname = "N/A";
      }

      if(Pokemon_type == "1"){
        Pokemon a = new Squirtle(answer_pokemonname);
        trainer.AddToBelt(new Pokeball(a));
      }
      else if(Pokemon_type == "2"){
        Pokemon b = new Bulbasaur(answer_pokemonname);
        trainer.AddToBelt(new Pokeball(b));
      }
      else{
        Pokemon c = new Charmander(answer_pokemonname);
        trainer.AddToBelt(new Pokeball(c));
      }
    }
  }