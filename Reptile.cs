using System;

namespace exercis
{
    class Reptile : Animal
    {

        public bool isColdBlooded { get; set; }
        public string? habitatType { get; set; }
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
        public void sunbathing()
            {
                Console.WriteLine($"{name} is sunbathing.");

            }
    }
}