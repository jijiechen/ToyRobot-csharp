namespace ToyRobot
{
    public interface ICommand
    {
        string Execute(Robot robot);
    }
}