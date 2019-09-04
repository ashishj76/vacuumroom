using System;

namespace VacuumRoom
{
    public class LegacyVacuumRobot : ILegacyVacuumRobot
    {
        public void RotateRight()
        {
            Console.WriteLine("Legacy Vacuum Robot Rotating right");
        }

        public void MoveForward()
        {
            Console.WriteLine("Legacy Vacuum Robot Moving Forward");
        }
    }
}