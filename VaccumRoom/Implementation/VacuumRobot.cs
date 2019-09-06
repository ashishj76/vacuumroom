using System;

namespace VacuumRoom.Implementation
{
    public class VacuumRobot : IVacuumRobot
    {
        public void RotateRight(int degrees)
        {
            Console.WriteLine($"Vacuum Robot Rotating right by {degrees} degrees");
        }

        public void MoveForward(int units)
        {
            Console.WriteLine($"Vacuum Robot Moving Forward by {units} units");
        }

        public void RotateLeft(int degrees)
        {
            Console.WriteLine($"Vacuum Robot Rotating left by {degrees} degrees");
        }

        public void MoveBackward(int units)
        {
            Console.WriteLine($"Vacuum Robot Moving Backward by {units} units");
        }
    }
}