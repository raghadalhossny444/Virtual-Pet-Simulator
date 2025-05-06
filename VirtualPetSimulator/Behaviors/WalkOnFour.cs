
using VirtualPetSimulator.Interfaces;

namespace VirtualPetSimulator.Behaviors
{
    public class WalkOnFour : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The pet is walking on four legs.");
            Console.WriteLine("in the walking on four behavior");

        }
    }
}