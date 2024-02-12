using System.Dynamic;

class Trainer{
    public String trainer_name;

    public Trainer(string AskTrainerName){
        this.trainer_name = AskTrainerName;
    }
    public List<Pokeball> PokeBelt = new List<Pokeball>();
    public List<Pokeball> BenchedPokeBelt = new List<Pokeball>();
    public String getTrainerName()
    {
        return trainer_name;
    }
    public void setTrainerName(String trainer_name)
    {
        this.trainer_name = trainer_name;
    }

    //function addToBelt() 1. pokeball 2. PokeballIndex
    public void AddToBelt(Pokeball pokeball){
        PokeBelt.Add(pokeball);
    }

    public List<Pokeball> getBelt() { 
        for(int i=0;i<PokeBelt.Count;i++){
            Console.WriteLine((i + 1) + " - " + PokeBelt[i].GetPokemon().getName());
        }
        return this.PokeBelt;
    }
    
    public Pokeball getBall(int pokeball_index) {
        return this.PokeBelt[pokeball_index];
    }
}   
