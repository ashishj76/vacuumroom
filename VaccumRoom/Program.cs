using System;

namespace VacuumRoom
{
    class Program
    {
        static void Main(string[] args)
        {

            //VacuumRobot() using new vacuum robot
            Console.WriteLine("Starting New Vacuum Implementation.....");
            VacuumRoom.VacuumRobotMovements(new VacuumRobot());

            //VacuumRobot() using Legacy Vacuum Robot
            Console.WriteLine("Starting Legacy Vacuum Implementation.....");
            VacuumRoom.VacuumRobotMovements(new LegacyVacuumAdapter(new LegacyVacuumRobot()));
            Console.ReadLine();
        }
    }
}
