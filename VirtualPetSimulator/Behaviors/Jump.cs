
using VirtualPetSimulator.Interfaces;

namespace VirtualPetSimulator.Behaviors
{
    public class Jump : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The pet is jumping.");
            Console.WriteLine("in the jumping behavior");
            
        }
    }
}