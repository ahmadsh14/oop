using System;

namespace exercis
{
    interface IMovable
    {
        void MoveForward(Double distance);
        void MoveBackward(Double distance);
        void TurnLeft(Double degrees);
        void TurnRight(Double degrees);
    }
}