#nullable disable
using ThanksCardServer2.Models;

namespace ThanksCardServer2.Models
{
    public class Reply
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Sonzai_Id { get; set; }
        public long ThanksCardId { get; set; }
        public virtual ThanksCard ThanksCard { get; set; }
        public long EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}