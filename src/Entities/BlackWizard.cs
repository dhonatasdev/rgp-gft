namespace gft.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            
        }

        public override string Attack(){
            return this.Name + " Invocou os mortos";
        }

        public string Attack(int Bonus){
            if (Bonus > 7){
                return this.Name + " Lançou um ataque super efetivo com bonus de " + Bonus;
            }
            else{
                return this.Name + " Lançou uma ataque com força franca com bonus de " + Bonus;
            }
        }
    }
}