using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ThanksCardAPI.Models
{
    public class Branch
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public virtual Department Parent { get; set; }
        public virtual ICollection<Department> Children { get; set; }

        public long DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}