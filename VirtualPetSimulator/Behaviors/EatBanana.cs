
using VirtualPetSimulator.Interfaces;

namespace VirtualPetSimulator.Behaviors
{
    public class EatBanana : IFeedable
    {
        public void Eat()
        {
            Console.WriteLine("The pet is eating a banana.");
            Console.WriteLine("in the eat banana behavior");
        }
    }
}