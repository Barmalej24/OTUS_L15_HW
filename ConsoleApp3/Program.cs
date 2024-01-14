namespace OTUS_L15_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IFlyingRobot w1 = new Quadcopter();
            IRobot w2 = new Quadcopter();
            var w3 = new Quadcopter();
            Console.WriteLine(w1.GetRobotType());
            Console.WriteLine(w2.GetRobotType());
            w3.Charge();            
        }
    }
}
