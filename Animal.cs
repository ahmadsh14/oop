using System;

namespace exercis
{
    public abstract class Animal : IMovable
    {
        public string? name;
        public int age;
        public string? gender;
        public double weight;
        public string? diet;
        public string? habitat;
        public void eat(string food)
        {
            Console.WriteLine($"{name} is eating {food}.");
        }
        public void sleep()
        {

            Console.WriteLine($"{name} is sleeping.");

        }
        public void makeSound()
        {
            Console.WriteLine($"{name} makes a sound.");
        }
        public virtual void MoveForward(Double distance)
        {
            Console.WriteLine($"Moving {distance} units forward");

        }
        public virtual void MoveBackward(Double distance)
        {
            Console.WriteLine($"Moving {distance} units backward.");

        }
        public virtual void TurnLeft(Double degrees)
        {
            Console.WriteLine($"Moving {degrees} to the left.");
        }
        public virtual void TurnRight(Double degrees)
        {
            Console.WriteLine($"Moving {degrees} to the right.");

        }

    }

}