using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkemaGPT.Lectio.Domain.Models
{
    public class Room
    {
        public string Id { get; set; }
        public string Type { get; set; }

        // If null, the room is not limited by capacity
        public int? Capcity { get; set; }
    }
}
