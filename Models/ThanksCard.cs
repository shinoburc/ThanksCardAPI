#nullable disable
using ThanksCardServer2.Models;

namespace ThanksCardServer2.Models
{
    public class ThanksCard
    {
      public long Id { get; set; }
      
      public DateTime Date { get; set; }
      public long SenderId { get; set; }
      public virtual Employee Sender { get; set; }
      public long DestinationId { get; set; }
      public virtual Employee Destination { get; set; }
      public long Title_Id { get; set; }
        public virtual Title Title { get; set; }
      public string ThanksCard_Content { get; set; }
      public long Template_Id { get; set; }
        public virtual Template Template { get; set; }
      public long Good_Number { get; set; }
      public string Alreadtread { get; set; }
      public long Sonzai_Id { get; set; }
    }
}