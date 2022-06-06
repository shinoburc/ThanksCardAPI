#nullable disable
namespace ThanksCardServer2.Models
{
    public class SearchThanksCard
    {
        public string SearchWord { get; set; }
        public DateOnly  SearchDate { get; set; }
    }
}