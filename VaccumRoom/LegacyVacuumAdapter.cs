using System;
using VacuumRoom;

namespace VacuumRoom
{
    public class LegacyVacuumAdapter : IVacuumRobot
    {
        /// <summary>
        /// Legacy adapter will have implementation for legacy interfaces(RotateRight & MoveForward)
        /// Calculating RotateLeft & MoveBackward based on existing inputs and legacy moves. 
        /// </summary>
        private readonly LegacyVacuumRobot _legacyRobot;

        public LegacyVacuumAdapter(LegacyVacuumRobot legacyVacuumRobot)
        {
            _legacyRobot = legacyVacuumRobot;
        }
        public void RotateRight(int degrees)
        {
            this._legacyRobot.RotateRight(degrees);
        }

        public void MoveForward(int units)
        {
            this._legacyRobot.MoveForward(units);
        }

        public void RotateLeft(int degrees)
        {
            this._legacyRobot.RotateRight(360 - degrees);
        }

        /// <summary>
        /// Implementing the MoveBackward for legacy. 
        /// </summary>
        /// <param name="units"></param>
        public void MoveBackward(int units)
        {

            this._legacyRobot.RotateRight(180);
            this._legacyRobot.MoveForward(units);
            this._legacyRobot.RotateRight(180);
        }
    }
}