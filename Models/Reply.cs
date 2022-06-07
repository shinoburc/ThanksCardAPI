#nullable disable
using ThanksCardServer2.Models;

namespace ThanksCardServer2.Models
{
    public class Reply
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public long Sonzai_Id { get; set; }
        public long UserId { get; set; }
        public virtual User User { get; set; }
    }
}