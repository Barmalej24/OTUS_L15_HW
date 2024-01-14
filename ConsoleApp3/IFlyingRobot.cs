namespace OTUS_L15_HW
{
    internal interface IFlyingRobot : IRobot
    {
        public new string GetRobotType()
        {
            return "I am a flying robot.";
        }        
    }
}
