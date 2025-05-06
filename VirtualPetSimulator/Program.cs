using VirtualPetSimulator.Pets;
using VirtualPetSimulator.Behaviors;
using VirtualPetSimulator.Interfaces;

namespace VirtualPetSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Virtual Pet Simulator!");
            Console.WriteLine("=================================\n");

            // Create movement behaviors
            IMovable walkingBehavior = new WalkOnFour();
            IMovable jumpingBehavior = new Jump();
            IFeedable bananaBehavior = new EatBanana();

            // Pet creation/adoption
            Console.WriteLine("Let's create your pet!");
            Console.Write("Enter pet name: ");
            string? name = Console.ReadLine();

            Console.Write("Enter pet age: ");
            int age = int.Parse(Console.ReadLine() ?? "1");

            Console.Write("Enter pet color: ");
            string? color = Console.ReadLine();

            Console.Write("Enter pet gender: ");
            string? gender = Console.ReadLine();

            Console.Write("Enter pet energy level (Low/Medium/High): ");
            string? energy = Console.ReadLine();

            Console.Write("Enter pet's favorite food: ");
            string? favoriteFood = Console.ReadLine();

            Console.WriteLine("\nChoose your pet type:");
            Console.WriteLine("1. Monkey");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Cat");
            Console.Write("Enter your choice (1-3): ");
            string? petType = Console.ReadLine();

            Pet? pet = null;
            switch (petType)
            {
                case "1":
                    pet = new Monkey(name ?? "George", age, color ?? "Brown", gender ?? "Male",
                        energy ?? "High", favoriteFood ?? "Banana", bananaBehavior, walkingBehavior);
                    break;
                case "2":
                    pet = new Dog(name ?? "Buddy", age, color ?? "Brown", gender ?? "Male",
                        energy ?? "High", favoriteFood ?? "Bone", new EatDryFood(), walkingBehavior, "Small");
                    break;
                case "3":
                    pet = new Cat(name ?? "Whiskers", age, color ?? "Gray", gender ?? "Female",
                        energy ?? "Medium", favoriteFood ?? "Fish", new EatDryFood(), walkingBehavior, "Small");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Creating a monkey by default.");
                    pet = new Monkey(name ?? "George", age, color ?? "Brown", gender ?? "Male",
                        energy ?? "High", favoriteFood ?? "Banana", bananaBehavior, walkingBehavior);
                    break;
            }

            Console.WriteLine($"\nGreat! You've adopted {pet.GetName()} the {pet.GetType().Name}!");
            Console.WriteLine("Let's play with your pet!\n");

            while (true)
            {
                Console.WriteLine("\nWhat would you like your pet to do?");
                Console.WriteLine("1. Walk on four legs");
                Console.WriteLine("2. Jump around");
                Console.WriteLine("3. Make sounds");
                Console.WriteLine("4. Eat");
                Console.WriteLine("5. Play");
                Console.WriteLine("6. Show pet's info");
                Console.WriteLine("7. Exit");

                Console.Write("\nEnter your choice (1-7): ");
                string? choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        pet.SetMovable(walkingBehavior);
                        pet.Move();
                        break;

                    case "2":
                        pet.SetMovable(jumpingBehavior);
                        pet.Move();
                        break;

                    case "3":
                        pet.MakeSound();
                        break;

                    case "4":
                        pet.Eat();
                        break;

                    case "5":
                        pet.Play();
                        break;

                    case "6":
                        Console.WriteLine($"Name: {pet.GetName()}");
                        Console.WriteLine($"Type: {pet.GetType().Name}");
                        Console.WriteLine($"Age: {pet.GetAge()}");
                        Console.WriteLine($"Color: {pet.GetColor()}");
                        Console.WriteLine($"Gender: {pet.GetGender()}");
                        Console.WriteLine($"Energy Level: {pet.GetEnergy()}");
                        Console.WriteLine($"Favorite Food: {pet.GetFavoriteFood()}");
                        break;

                    case "7":
                        Console.WriteLine($"Thank you for playing with {pet.GetName()}! Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
