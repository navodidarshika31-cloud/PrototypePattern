using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class IndustrialRobot : Robot
    {
        public string IndustrialTask { get; set; }

        public override IRobotPrototype Clone()
        {
            return (IndustrialRobot)this.MemberwiseClone();
        }
    }
}
