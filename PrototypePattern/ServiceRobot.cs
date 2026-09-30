using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class ServiceRobot : Robot
    {
        public string ServiceTask { get; set; }

        public override IRobotPrototype Clone()
        {
            return (ServiceRobot)this.MemberwiseClone();
        }
    }
}
