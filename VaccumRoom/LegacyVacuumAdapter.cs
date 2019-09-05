using System;
using VacuumRoom;

namespace VacuumRoom
{
    public class LegacyVacuumAdapter : IVacuumRobot
    {
        private readonly LegacyVacuumRobot _legacyVacuumRobot;

        public LegacyVacuumAdapter(LegacyVacuumRobot legacyVacuumRobot)
        {
            _legacyVacuumRobot = legacyVacuumRobot;
        }
        public void RotateRight(int degrees)
        {
            this._legacyVacuumRobot.RotateRight(degrees);
        }

        public void RotateLeft(int degrees)
        {
            Console.WriteLine($"Vacuum Robot Rotate Left by {degrees} degrees.");
        }

        public void MoveForward(int units)
        {
            this._legacyVacuumRobot.MoveForward(units);
        }

        public void MoveBackward(int units)
        {
            Console.WriteLine($"Vacuum Robot Moving Forward by {units} units.");
        }
    }
}