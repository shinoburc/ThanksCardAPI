using System;
using System.Collections.Generic;

namespace ThanksCardAPI.Models
{
    public class ThanksCard
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public virtual User From { get; set; }
        public virtual User To { get; set; }
        public DateTime CreatedDateTime { get; set; }

        // 多対多: ThanksCard エンティティは ThanksCardTag 交差エンティティを経由して複数の Tag エンティティを持つ
        public virtual ICollection<ThanksCardTag> ThanksCardTags { get; set; }
    }
}
