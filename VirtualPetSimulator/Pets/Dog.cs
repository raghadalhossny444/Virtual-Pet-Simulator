using VirtualPetSimulator.Interfaces;
namespace VirtualPetSimulator.Pets
{
    public class Dog : Pet
    {
        private string Size { get; set; }
        public Dog(string name, int age, string color, string gender, string energy, string favoriteFood, IFeedable feedable, IMovable movable, string size) : base(name, age, color, gender, energy, favoriteFood, feedable, movable)
        {
            Size = size;
        }


        public override void Move()
        {
            Movable.Move();
        }
        public override void Eat()
        {
            Feedable.Eat();
        }
        public override void Play()
        {
            Console.WriteLine("The dog is playing.");
        }
        public override void MakeSound()
        {
            Console.WriteLine("The dog is barking.");
        }

        public void Fetch()
        {
            Console.WriteLine("The dog is fetching a ball.");
        }
    }
}