using VirtualPetSimulator.Interfaces;

namespace VirtualPetSimulator.Pets
{
    public class Monkey : Pet
    { 
        public Monkey(string name, int age, string color, string gender, string energy, string favoriteFood, IFeedable feedable, IMovable movable) : base(name, age, color, gender, energy, favoriteFood, feedable, movable)
        {

        }

        public override void Eat()
        {
            Feedable.Eat();
        }

        public override void Move()
        {
            Movable.Move();
        }

        public override void MakeSound(){
            Console.WriteLine("The monkey is screaming.");
        }    

        public override void Play(){
            Console.WriteLine("The monkey is playing.");
        }
        
    }
}