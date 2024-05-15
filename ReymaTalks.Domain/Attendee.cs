using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReymaTalks.Domain
{
    public class Attendee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Years { get; set; }
    }
}
