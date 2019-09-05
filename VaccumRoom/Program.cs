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
            vacuumRobot.MoveForward(10);
            vacuumRobot.MoveBackward(5);
            vacuumRobot.RotateRight(180);
            vacuumRobot.RotateLeft(90);
        }
    }
}
