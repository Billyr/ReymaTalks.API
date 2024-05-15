using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReymaTalks.Common
{
    public interface IDateTime
    {
        DateTimeOffset Now { get; }
    }
}
