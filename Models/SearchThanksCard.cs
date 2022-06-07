#nullable disable
namespace ThanksCardServer2.Models
{
    public class SearchThanksCard
    {
        public string SearchWord1 { get; set; }
        public string SearchWord2 { get; set; }
        public DateOnly  SearchDate { get; set; }
    }
}