namespace c1.src.Entities
{
    public class Arus
    {

        
        public string Name;
        public int level;
        public string HeroType;

        public Arus(string Name, int Level, string Herotype){
            this.Name = Name;
            this.level = Level;
            this.HeroType = Herotype;
        }

        public Arus() {

        }

        public override string ToString()
        {
            return this.HeroType;
        }

    }
}