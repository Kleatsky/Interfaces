using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesConsole
{
    public class Quadcopter : IFlyingRobot, IChargeable
    {
        private List<string> _components;
        private int batary;
        public Quadcopter()
        {
            _components = new List<string>{ "rotor1","rotor2","rotor3","rotor4"};
            batary = 0;
        }

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
            batary = 0;
        }

        public List<string> GetComponents() => _components;

        public string GetInfo() => batary > 0 ? "Batary is Full." : "Batary is empty";

        public string GetRobotType() => "I am a robot quadcopter.";
    }
}
