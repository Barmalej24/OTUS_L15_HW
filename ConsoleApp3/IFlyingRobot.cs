namespace OTUS_L15_HW
{
    internal interface IFlyingRobot : IRobot
    {
        string GetRobotType()
        {
            return "I am a flying robot.";
        }        
    }
}
