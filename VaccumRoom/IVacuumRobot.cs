namespace VacuumRoom
{
    public interface IVacuumRobot
    {
        void RotateRight(int degrees);
        void RotateLeft(int degrees);
        void MoveForward(int units);
        void MoveBackward(int units);
    }
}