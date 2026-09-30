using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public interface IRobotPrototype
    {
        IRobotPrototype Clone();
    }
}
