namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human person1 = new Human(new Pet(5), "Patrik");
            Console.WriteLine($"{person1.Name}'s pet is {person1.humanPet.Age} years old");
        }
        public class Pet
        {
            public Pet(int age)
            {
                Age = age;
            }
            public string Type;
            public int Age;
        }
        public class Human
        {
            public Human(Pet pet, string name )
            {
                Name = name;
                humanPet = pet;
            }
            public string Name;
            public Pet humanPet;
        }
    }
}