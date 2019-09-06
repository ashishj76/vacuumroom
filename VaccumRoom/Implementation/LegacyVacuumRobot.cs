using System;

namespace VacuumRoom.Implementation
{
    public class LegacyVacuumRobot : ILegacyVacuumRobot
    {
        public void RotateRight(int degrees)
        {
            Console.WriteLine($"Legacy Vacuum Robot Rotating right by {degrees} degrees");
        }

        public void MoveForward(int units)
        {
            Console.WriteLine($"Legacy Vacuum Robot Moving Forward by {units} units");
        }
    }
}