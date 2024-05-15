using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReymaTalks.Common
{
    public class MachineDateTime : IDateTime
    {
        public DateTimeOffset Now => DateTimeOffset.Now;
    }
}
