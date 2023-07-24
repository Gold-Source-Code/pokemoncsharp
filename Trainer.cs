class Trainer{
    public String trainer_name;

    public Trainer(string AskTrainerName){
        this.trainer_name = AskTrainerName;
    }
    public List<Pokeball> PokeBelt = new List<Pokeball>();
    public String getTrainerName()
    {
        return trainer_name;
    }
    public void setTrainerName(String trainer_name)
    {
        this.trainer_name = trainer_name;
    }

    //function addToBelt() 1. pokeball 2. PokeballIndex
    public void AddToBelt(Pokeball pokeball, int PokeballIndex){
        PokeBelt.Add(pokeball);
    }

    public List<Pokeball> getBelt() {
        return PokeBelt;
    }
}

