using System;

namespace VacuumRoom
{
    public class VacuumRoom
    {
        public static void VacuumRobotMovements(IVacuumRobot vacuumRobot)
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