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
            int Life = 4;
            public Dog(string y)
            {
                name = y;
            }
            public int Bite()
            {
                
                Console.WriteLine("The dog " + name + " bit you!");
                return Life-- ;
                
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
            public void Greet()
            {
                Console.WriteLine("The car " + name + " says mjaau");
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
            DoMeanThings(buddy);

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
