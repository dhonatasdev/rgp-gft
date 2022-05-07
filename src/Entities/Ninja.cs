namespace gft.src.Entities
{
    public class Ninja: Hero
    {
        public Ninja (string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public override string Attack(){
            return this.Name + " Atacou com a sua Shuriken";
        }

        public string Attack(int Bonus){
            if (Bonus > 3){
                return this.Name + " Lançou um ataque super efetivo com bonus de " + Bonus;
            }
            else{
                return this.Name + " Lançou uma ataque com força franca com bonus de " + Bonus;
            }
        }
    }
}