using c1.src.Entities;

namespace c1
{
    class Hello {         
        static void Main(string[] args)
        {
            Arus hero = new Arus("Joao", 15, "Cavaleiro");

            Console.WriteLine(hero.ToString());
        }
    }
}