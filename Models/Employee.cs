#nullable disable
using ThanksCardServer2.Models;

namespace ThanksCardServer2.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public long Cd { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public long Sonzai_Id { get; set; }
        public long Belongs_Id { get; set; }
        public virtual Belong Belongs { get; set; }
    }
}