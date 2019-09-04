using VacuumRoom;

namespace VacuumRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            VacuumRoom();
        }

        private static void VacuumRoom()
        {
            LegacyVacuumRobot legacyVacuumRobot = new LegacyVacuumRobot();
            IVacuumRobot vacuumRobot = new LegacyVacuumAdapter(legacyVacuumRobot);
            vacuumRobot.MoveForward();
            vacuumRobot.MoveBackward();
            vacuumRobot.RotateRight();
            vacuumRobot.RotateLeft();
        }
    }
}
