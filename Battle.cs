class Battle{
public Pokemon? pokemon1;
public Pokemon? pokemon2;
public Trainer trainer1;
public Trainer trainer2;
public int PokeballIndex;
public int PokeballIndex2;
public string? winner;

// Registers values into script.
public Battle(Trainer trainer1, Trainer trainer2) {
    this.trainer1 = trainer1;
    this.trainer2 = trainer2;
}
// Checks the type. Runs the Win check. Adds Score.
public string checktype(Pokemon pokemon1, Pokemon pokemon2){
    string type1 = pokemon1.getStrength();
    string type2 = pokemon2.getStrength();

    if ((type1 == "Fire" && type2 == "Grass") || (type1 == "Water" && type2 == "Fire") || (type1 == "Grass" && type2 == "Water")) {
        Console.WriteLine(pokemon1.getName() + " has the advantage.");
        //Arena.scoreboard["player1"] = Arena.scoreboard["player1"] + 1;
        //Console.WriteLine(Arena.scoreboard["player1"]);
        pokemon2.setFaintState(pokemon2.getName());
        winner = "one";
        return winner;
        //Arena.showselection(pokemon2.getName(), trainer2);
        //arena.selectpokemon(trainer2);
    }
    else if ((type2 == "Fire" && type1 == "Grass") || (type2 == "Water" && type1 == "Fire") || (type2 == "Grass" && type1 == "Water")){
        Console.WriteLine(pokemon2.getName() + " has the advantage.");
        //Arena.scoreboard["player2"] = Arena.scoreboard["player2"] + 1;
        //Console.WriteLine(Arena.scoreboard["player2"]);
        pokemon1.setFaintState(pokemon1.getName());
        winner = "two";
        return winner;
        //Arena.showselection(pokemon1.getName(), trainer1);
        //arena.selectpokemon(trainer1);
    }
    else{
        Console.WriteLine("It's a neutral battle.");
        winner = "draw";
        return winner;
    }
}
// Growl loop.
    public void attackloop(Trainer player1, int index1, Trainer player2, int index2){
    string? answer1 = "y"; // Battle
    while (answer1 == "y"){
    Console.WriteLine("Use Growl? [Y/N]");
    answer1 = Console.ReadLine();
        if (answer1 == "y"){
            Console.WriteLine(player1.getBall(index1).GetPokemon().Growl());
            Console.WriteLine(player2.getBall(index2).GetPokemon().Growl());
            }
        else{
            Console.WriteLine(player1.getBall(index1).GetPokemon().getName() + " was returned to Pokeball " + (index1 + 1));
            endbattle();
            }
        }
    }
        public static void endbattle(){
        Console.WriteLine(Arena.scoreboard["player1"]);
        Console.WriteLine(Arena.scoreboard["player2"]);
        Arena.scoreboard["player1"] = 0;
        Arena.scoreboard["player2"] = 0;
    }
}
