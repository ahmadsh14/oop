using System;

namespace exercis
{
    public class Mammal : Animal
    {
        public string? furColor;
        public int gestationPeriod;

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
        public void nurse()
        {
            Console.WriteLine($"{name} is nursing its young.");
        }

    }
}