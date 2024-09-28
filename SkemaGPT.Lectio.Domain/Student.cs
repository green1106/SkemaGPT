using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkemaGPT.Lectio.Domain.Models
{
    public class Student
    {
        public string Id { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
