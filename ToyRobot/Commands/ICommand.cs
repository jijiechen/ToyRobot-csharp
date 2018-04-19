using ToyRobot.Models;

namespace ToyRobot.Commands
{
    public interface ICommand
    {
        string Execute(Robot robot);
    }
}