#nullable disable
using ThanksCardServer2.Models;

namespace ThanksCardServer2.Models
{
    public class Belong
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long sonzai_id { get; set; }
        public long Parent_Id { get; set; }
    }
}