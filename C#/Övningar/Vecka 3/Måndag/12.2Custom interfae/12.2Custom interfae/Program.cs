using System;

namespace _12._2Custom_interfae
{
    
    
    public class Program
    {
        public interface IFriendly
        {
            void Greet();
            void ThanksForDinner(string meal);
        }
        public interface IAggressive
        {
            int Bite();
            void ShowTeeth();
        }
        public class Dog : IFriendly, IAggressive
        {
            public string name { get; set; }
           
            public Dog(string y)
            {
                name = y;
            }
            public int Bite()
            {   
                Console.WriteLine("The dog " + name + " bit you!");
                Random rnd = new Random();
                int bite = rnd.Next(1, 4);
                switch (bite)
                {
                    case 1:
                        Console.WriteLine("You lost one leg");
                        break;
                    case 2:
                        Console.WriteLine("You lost two legs");
                        break;
                    case 3:
                        Console.WriteLine("You lost one arm");
                        break;
                    case 4:
                        Console.WriteLine("You lost both your arms");
                        break;
                }
                return bite;
            }

            public void Greet()
            {
                Console.WriteLine("The dog buddy says woof");
            }
            public void ThanksForDinner(string meal)
            {
                Console.WriteLine("The dog buddy thank you for the " + meal);
            }

            public void ShowTeeth()
            {
                Console.WriteLine("The dog " + name + " shows his teeth");
            }


        }
        public class Cat : IFriendly
        {
            public string name { get; set; }
            
            public Cat(string y)
            {
                name = y;
            }
            public void Greet()
            {
                Console.WriteLine("The cat " + name + " says mjaau");
            }

            public void ThanksForDinner(string meal)
            {
                Console.WriteLine("The cat " + name + " thank you for the " + meal);
            }
        }
        static void Main(string[] args)
        {
            Dog buddy = new Dog("Buddy");
            Cat musse = new Cat("Musse");

            DoNiceThings(buddy);
            Console.WriteLine();
            DoMeanThings(buddy);
            Console.WriteLine();
            DoNiceThings(musse);
        }

        private static void DoMeanThings(IAggressive c)
        {
            c.Bite();
          
            c.ShowTeeth();
        }

        public static void DoNiceThings(IFriendly c)
        {        
            c.Greet();
            c.ThanksForDinner("Mouse");           
        }
    }
}
