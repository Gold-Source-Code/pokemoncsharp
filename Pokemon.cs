abstract class Pokemon{
    string name;
    string strength;
    string weakness;

    public Pokemon(string name, string strength, string weakness){
        this.name = name;
        this.strength = strength;
        this.weakness = weakness;
    }

    public string getName(){
        return name;
    }

        public string getStrength(){
        return strength;
    }

        public string getWeakness(){
        return weakness;
    }

    public abstract string Growl();
 
}
class Charmander : Pokemon{
        public Charmander(string name, string strength, string weakness) : base(name, strength, weakness){ }
        public override string Growl(){
            return this.getName() + " says Charmander!";
        }
}
class Bulbasaur : Pokemon{
        public Bulbasaur(string name, string strength, string weakness) : base(name, strength, weakness){ }
        public override string Growl(){
            return this.getName() + " says Bulbasaur!";
        }
}
class Squirtle : Pokemon{
        public Squirtle(string name, string strength, string weakness) : base(name, strength, weakness){ }
        public override string Growl(){
            return this.getName() + " says Squirtle!";
        }
}