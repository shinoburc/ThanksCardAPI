#nullable disable

namespace ThanksCardServer2.Models
{
    public class Belong
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long SonzaiId { get; set; }
        public long? Parent_Id { get; set; }
        public virtual Belong Parent { get; set; }
        public virtual ICollection<Belong> Children { get; set; }
    }
}