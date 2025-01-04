using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii
{
    public abstract class Animal
    {
        public abstract void MakeSound();

        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
    public interface IRunnable
    {
        void Run();
    }

    public class Dog : Animal, IRunnable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Câine latră");
        }
        public override void Eat()
        {
            Console.WriteLine("Câinele mănâncă oase");
        }
        public void Run()
        {
            Console.WriteLine("Dog runs");
        }
    }
    public class Cat : Animal, IRunnable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat miau sound");
        }
        public override void Eat()
        {
            Console.WriteLine("Cat runs");
        }
        public void Run()
        {
            Console.WriteLine("Cat runs");
        }
    }

}
