#nullable disable
using ThanksCardServer2.Models;

namespace ThanksCardServer2.Models
{
    public class Midle
    {
        public long Id { get; set; }
        public long ThanksCardId { get; set; }
        public virtual ThanksCard ThanksCard { get; set; }
        public long ReplyId { get; set; }
        public virtual Reply Reply { get; set; }

    }
}