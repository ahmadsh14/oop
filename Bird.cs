using System;

namespace exercis
{
    class Bird : Animal
    {
        public double wingspan;
        public bool canFly;
        public override void MoveForward(Double distance)
        {
            Console.WriteLine($"Moving {distance} units forward");

        }
        public override void MoveBackward(Double distance)
        {
            Console.WriteLine($"Moving {distance} units backward.");

        }
        public override void TurnLeft(Double degrees)
        {
            Console.WriteLine($"Moving {degrees} to the left.");
        }
        public override void TurnRight(Double degrees)
        {
            Console.WriteLine($"Moving {degrees} to the right.");

        }
        public void fly()
        {
            Console.WriteLine($"{name} is flying.");
        }
    }
}