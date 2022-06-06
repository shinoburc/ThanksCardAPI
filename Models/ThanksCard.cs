#nullable disable
using ThanksCardServer2.Models;

namespace ThanksCardServer2.Models
{
    public class ThanksCard
    {
        public long Id { get; set; }
        public DateOnly Date { get; set; }
        public long FromId { get; set; }
        public virtual Employee From { get; set; }
        public long ToId { get; set; }
        public virtual Employee To { get; set; }
        public long TitleId { get; set; }
        public virtual Title Title { get; set; }
        public string Content { get; set; }
        public long TemplateId { get; set; }
        public virtual Template Template { get; set; }
        public long GoodNumber { get; set; }
        public string Alreadyread { get; set; }
        public long ThanksCardSonzaiId { get; set; }
    }
}