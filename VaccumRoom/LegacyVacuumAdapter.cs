using System;

namespace VacuumRoom
{
    public class LegacyVacuumAdapter : IVacuumRobot
    {
        private readonly LegacyVacuumRobot _legacyVacuumRobot;

        public LegacyVacuumAdapter(LegacyVacuumRobot legacyVacuumRobot)
        {
            _legacyVacuumRobot = legacyVacuumRobot;
        }
        public void RotateRight()
        {
            this._legacyVacuumRobot.RotateRight();
        }

        public void RotateLeft()
        {
            Console.WriteLine("Vacuum Robot Rotate Left");
        }

        public void MoveForward()
        {
            this._legacyVacuumRobot.MoveForward();
        }

        public void MoveBackward()
        {
            Console.WriteLine("Vacuum Robot Moving Forward");
        }
    }
}