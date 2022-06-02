#nullable disable
using ThanksCardServer2.Models;

namespace ThanksCardServer2.Models
{
    public class Midle
    {
        public long Id { get; set; }
        public long ThanksCard_Id { get; set; }
        public virtual ThanksCard ThanksCard { get; set; }
        public long Reply_Id { get; set; }
    }
}