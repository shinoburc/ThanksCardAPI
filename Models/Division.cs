using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThanksCardAPI.Models
{
    public class Division
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
