using VirtualPetSimulator.Interfaces;

#nullable disable
namespace VirtualPetSimulator.Pets
{
    public abstract class Pet
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected string Color { get; set; }
        protected string Gender { get; set; }
        protected string Energy { get; set; }
        protected string FavoriteFood { get; set; }
        protected IFeedable Feedable { get; set; }
        protected IMovable Movable { get; set; }



        public Pet(string name, int age, string color, string gender, string energy, string favoriteFood, IFeedable feedable, IMovable movable)
        {
            Name = name;
            Age = age;
            Color = color;
            Gender = gender;
            Energy = energy;
            FavoriteFood = favoriteFood;
            Feedable = feedable;
            Movable = movable;
        }

        public abstract void Eat();
        public abstract void Move();
        public abstract void Play();
        public abstract void MakeSound();

        // Add public methods to get pet information
        public string GetName() => Name;
        public int GetAge() => Age;
        public string GetColor() => Color;
        public string GetGender() => Gender;
        public string GetEnergy() => Energy;
        public string GetFavoriteFood() => FavoriteFood;
        public IFeedable GetFeedable() => Feedable;
        public IMovable GetMovable() => Movable;

        // Setter methods
        public void SetMovable(IMovable movable) => Movable = movable;
        public void SetFeedable(IFeedable feedable) => Feedable = feedable;
    }
}