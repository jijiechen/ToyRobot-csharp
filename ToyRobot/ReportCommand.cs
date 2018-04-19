namespace ToyRobot
{
    public class ReportCommand : ICommand
    {
        public static ReportCommand Parse(string input)
        {
            if(input == "REPORT")
                return new ReportCommand();

            return null;
        }
    }
}