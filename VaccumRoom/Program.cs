using System;

namespace VacuumRoom
{
    class Program
    {
        static void Main(string[] args)
        {

            IVacuumRobot vacuumRobot = new VacuumRobot();

            //VacuumRobot() using new vacuum robot
            Console.WriteLine("Starting New Vacuum Implementation.....");
            VacuumRobotMovements(vacuumRobot);

            //VacuumRobot() using Legacy Vacuum Robot
            Console.WriteLine("Starting Legacy Vacuum Implementation.....");
            vacuumRobot = new LegacyVacuumAdapter(new LegacyVacuumRobot());
            VacuumRobotMovements(vacuumRobot);

            Console.ReadLine();
        }

        private static void VacuumRobotMovements(IVacuumRobot vacuumRobot)
        {
            Console.WriteLine("-----------------------------------------------------");
            vacuumRobot.MoveForward(10);
            Console.WriteLine("-----------------------------------------------------");
            vacuumRobot.MoveBackward(5);
            Console.WriteLine("-----------------------------------------------------");
            vacuumRobot.RotateRight(180);
            Console.WriteLine("-----------------------------------------------------");
            vacuumRobot.RotateLeft(90);
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
