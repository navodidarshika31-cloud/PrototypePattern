using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class EntertainmentRobot : Robot
    {
        public string EntertainmentFeature { get; set; }

        public override IRobotPrototype Clone()
        {
            return (EntertainmentRobot)this.MemberwiseClone();
        }
    }
}
