using ExamP2;

namespace ExamP2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //In the Main method, create objects and demonstrate polymorphism.

            Animal myDog = new Dog();
            Animal myCat = new Cat();

            Console.Write("Dog sounds: "); myDog.MakeSound();


            Console.Write("Cat sounds: "); myCat.MakeSound();




        }
    }

    //Create a base class Animal with method MakeSound(). 
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some animal sound");
        }

        
    }

    //Create two derived classes: Dog and Cat, each overriding MakeSound() with a different message.

    public class Dog : Animal {

        public override void MakeSound()
        {
            Console.WriteLine("Ho,Ho");
        }


    }


    public class Cat : Animal {

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }


}




 
