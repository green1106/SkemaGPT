using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkemaGPT.Lectio.Domain.Models
{
    public class Teacher
    {
        public string Initials { get; set; }
        ICollection<Group> Groups { get; set; }
    }
}
