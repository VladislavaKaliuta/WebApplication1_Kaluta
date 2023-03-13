using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1_Kaluta.Models
{
    public class teachers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<subjects> Subjects { get; set; }
        public string Department { get; set; }
    }
}
