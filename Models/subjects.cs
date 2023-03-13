using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1_Kaluta.Models
{
    public class subjects
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<teachers> Teachers { get; set; }
        public string Department { get; set; }

    }
}
