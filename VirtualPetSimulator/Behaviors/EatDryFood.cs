
using VirtualPetSimulator.Interfaces;

namespace VirtualPetSimulator.Behaviors
{
    public class EatDryFood : IFeedable
    {
        public void Eat()
        {
            Console.WriteLine("The pet is eating dry food.");
            Console.WriteLine("in the eat dry food behavior");
        }
    }
}