namespace OTUS_L15_HW
{
    internal interface IRobot
    {
        string GetInfo()
        {
            throw new NotImplementedException();
        }
        List<string> GetComponents()
        {
            throw new NotImplementedException();
        }
        string GetRobotType()
        {
            return "I am a simple robot.";
        }
    }
}
