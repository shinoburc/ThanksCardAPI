#nullable disable
using ThanksCardServer2.Models;

namespace ThanksCardServer2.Models
{
    public class Template
    {
        public long Id { get; set; }

        public string Template_Name { get; set; }
        public string Template_Content { get; set; }
    }
}