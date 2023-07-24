class Pokeball{
    Pokemon pokemon;

    public Pokeball(Pokemon pokemon){
        this.pokemon = pokemon;
    }

    public void Open(){
        Console.WriteLine("The pokeball is opened.");
        Console.WriteLine(pokemon.Growl());
    }

    public void Close(){
        Console.WriteLine("The pokeball is closed.");
    }

    public Pokemon GetPokemon() {
        return pokemon;
    }
}