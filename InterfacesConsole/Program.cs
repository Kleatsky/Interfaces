namespace InterfacesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadcopter quadcopter = new Quadcopter();
            Console.WriteLine(quadcopter.GetInfo());
            quadcopter.Charge();
            //Console.WriteLine((quadcopter as IFlyingRobot)?.GetRobotType());
            Console.WriteLine(quadcopter.GetRobotType());
            Console.WriteLine(String.Join(", ", quadcopter.GetComponents()));
        }
    }
}
