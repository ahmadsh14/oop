using System;

namespace exercis
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal dog = new Mammal();
            dog.name = "max";
            dog.age = 6;
            dog.gender = "male";
            dog.weight = 5;
            dog.furColor = "Black";
            dog.MoveForward(17);
            dog.TurnRight(50);
            dog.eat("meat");
            dog.nurse();
            dog.sleep();
            dog.makeSound();

            Bird owl = new Bird();
            owl.name = "mohsen";
            owl.age = 10;
            owl.gender = "Male";
            owl.MoveBackward(100);
            owl.TurnLeft(180);
            owl.eat("mouse");
            owl.fly();

        }
    }
}