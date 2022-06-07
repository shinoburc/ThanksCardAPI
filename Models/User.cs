#nullable disable
using ThanksCardServer2.Models;

namespace ThanksCardServer2.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public long Sonzai_Id { get; set; }
        public bool IsEmployee { get; set; }
        // 多対1: User エンティティは1つの Department エンティティに属する
        public long? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}