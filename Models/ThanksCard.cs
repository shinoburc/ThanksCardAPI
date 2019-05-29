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

        // ���Α�: ThanksCard �G���e�B�e�B�� ThanksCardTag �����G���e�B�e�B���o�R���ĕ����� Tag �G���e�B�e�B������
        public virtual ICollection<ThanksCardTag> ThanksCardTags { get; set; }
    }
}
