namespace OTUS_L15_HW
{
    internal interface IRobot
    {
        public string GetInfo()
        {
            throw new NotImplementedException();
        }
        public List<string> GetComponents()
        {
            throw new NotImplementedException();
        }
        public string GetRobotType()
        {
            return "I am a simple robot.";
        }
    }
}
