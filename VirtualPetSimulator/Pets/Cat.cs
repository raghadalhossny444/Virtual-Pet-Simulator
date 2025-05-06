using VirtualPetSimulator.Interfaces;

namespace VirtualPetSimulator.Pets
{
    public class Cat : Pet
    {
        private string Type { get; set; }
        public Cat(string name, int age, string color, string gender, string energy, string favoriteFood,
        IFeedable feedable, IMovable movable, string type)
        : base(name, age, color, gender, energy, favoriteFood, feedable, movable)
        {
            Type = type;
        }

        public override void Eat()
        {
            Feedable.Eat();
        }
        public override void Move()
        {
            Movable.Move();
        }
        public override void Play()
        {
            Console.WriteLine("The cat is playing.");
        }
        public override void MakeSound()
        {
            Console.WriteLine("The cat is meowing.");
        }

        public void Purr()
        {
            Console.WriteLine("The cat is purring.");
        }
    }
}