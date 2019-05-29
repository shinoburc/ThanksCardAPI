using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThanksCardAPI.Models
{
    public class Tag
    {
        public long Id { get; set; }
        public string Name { get; set; }

        // 多対多: Tag エンティティは ThanksCardTag 交差エンティティを経由して複数の ThanksCard エンティティを持つ
        public virtual ICollection<ThanksCardTag> ThanksCardTags { get; set; }
    }
}
