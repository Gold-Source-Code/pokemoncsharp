class Arena{
public string? winner;
public Pokemon? pokemon1;
public Pokemon? pokemon2;
public Trainer trainer1;
public Trainer trainer2;
public Battle battle;
public int PokeballIndex;
public int PokeballIndex2;
public Arena(Trainer trainer1, Trainer trainer2, Battle battle){
    this.trainer1 = trainer1;
    this.trainer2 = trainer2;
    this.battle = battle;
}
// The scoreboard.
    public static Dictionary<string, int> scoreboard =
        new Dictionary<string, int>();

    public static void scoreboardcreate(){
        scoreboard.Add("player1", 0);
        scoreboard.Add("player2", 0);
    }

// Belts & Trainer get displayed.
static public void showselection(string name, Trainer player){
    Console.WriteLine(name);
    player.getBelt();
    }

    // Selects the pokemon and places them into battle through PokeballIndex.
 public int selectpokemon(Trainer player1){
    Console.WriteLine("Which Pokemon do you want to pull out?"); // Arena
    string? PokeballIndexAsk = Console.ReadLine();
    int PokeballIndex = Convert.ToInt32(PokeballIndexAsk);
    if(PokeballIndexAsk == null){
          PokeballIndex = 0;
          Battle.endbattle();
          }
    else{
        PokeballIndex = PokeballIndex - 1;
        }
    string CurrentPokemon = player1.getBall(PokeballIndex).GetPokemon().getName();
    Console.WriteLine("Pokemon: " + CurrentPokemon);
    Console.WriteLine("===============");
    Console.WriteLine("Strong against: " + player1.getBall(PokeballIndex).GetPokemon().getStrength());
    Console.WriteLine("Weak against: " + player1.getBall(PokeballIndex).GetPokemon().getWeakness());
    Console.WriteLine("===============");
    Console.WriteLine(player1.getBall(PokeballIndex).GetPokemon().Growl());
    pokemon1 = player1.getBall(PokeballIndex).GetPokemon();
    return PokeballIndex;
}
// Selects the pokemon and places them into battle through PokeballIndex2.
public int selectpokemon2(Trainer player2){
      Console.WriteLine("Which Pokemon do you want to pull out?");
     string? PokeballIndexAsk2 = Console.ReadLine();
        int PokeballIndex2 = Convert.ToInt32(PokeballIndexAsk2);
     if(PokeballIndexAsk2 == null){
       PokeballIndex2 = 0;
       Battle.endbattle();
          }
        else{
       PokeballIndex2 = PokeballIndex2 - 1;
        }
    string CurrentPokemon2 = player2.getBall(PokeballIndex2).GetPokemon().getName();
    Console.WriteLine("Pokemon: " + CurrentPokemon2);
    Console.WriteLine("===============");
    Console.WriteLine("Strong against: " + player2.getBall(PokeballIndex2).GetPokemon().getStrength());
    Console.WriteLine("Weak against: " + player2.getBall(PokeballIndex2).GetPokemon().getWeakness());
    Console.WriteLine("===============");
    Console.WriteLine(player2.getBall(PokeballIndex2).GetPokemon().Growl());
    pokemon2 = player2.getBall(PokeballIndex2).GetPokemon();
    return PokeballIndex2;
    }

    public void battleloop(string winner){
        while (true){
        if (winner == "start" || winner == "draw"){
            selectpokemon(trainer1);
            selectpokemon2(trainer2);
            showselection(pokemon1.getName(), trainer1);
            showselection(pokemon2.getName(), trainer2);
            battleloop(battle.checktype(pokemon1, pokemon2));
        }
        if (winner == "one"){
            selectpokemon2(trainer2);
            showselection(pokemon2.getName(), trainer2);
            battleloop(battle.checktype(pokemon1, pokemon2));
        }
        if (winner == "two"){
            selectpokemon(trainer1);
            showselection(pokemon1.getName(), trainer1);
            battleloop(battle.checktype(pokemon1, pokemon2));
        }
        }
    }
}
// LEES DIT
// Maak Battle los van Arena. GEEN ARENA FUNCTIONS IN BATTLE.