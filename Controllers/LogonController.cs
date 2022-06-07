using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThanksCardServer2.Models;

namespace ThanksCardServer2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogonController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public LogonController(ApplicationContext context)
        {
            _context = context;
            if (_context.Users.Count() == 0)
            {
                _context.Users.Add(new User { Id = 0001, Name = "比嘉哲平", Password = "Higa0001", IsEmployee = true, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0002, Name = "山田慎一", Password = "Yama0002", IsEmployee = true, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0003, Name = "金城まゆみ", Password = "Kinj0003", IsEmployee = true, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0004, Name = "高木弘樹", Password = "Taka0004", IsEmployee = true, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0005, Name = "小山育雄", Password = "Koya0005", IsEmployee = true, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0006, Name = "田原美由紀", Password = "Taha0006", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0007, Name = "知念雅人", Password = "Chie0007", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0008, Name = "山城亮介", Password = "Yama0008", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0009, Name = "比嘉暉一郎", Password = "Higa0009", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0010, Name = "安田千絵子", Password = "Yasu0010", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0011, Name = "下地綾乃", Password = "Shim0011", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0012, Name = "平良祐作", Password = "Tair0012", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0013, Name = "前川博", Password = "Maek0013", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0014, Name = "藤川裕香", Password = "Fuji0014", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0015, Name = "新谷沢子", Password = "Shin0015", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0016, Name = "鈴木一郎", Password = "Suzu0016", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0017, Name = "田中五郎", Password = "Than0017", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0018, Name = "城間真澄", Password = "Shir0018", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0019, Name = "足立康史", Password = "Adac0019", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0020, Name = "武藤純子", Password = "Muto0020", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0021, Name = "西野大夢", Password = "Nisi0021", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0022, Name = "山根秀次郎", Password = "Yama0022", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0023, Name = "丹羽佑治", Password = "Tanb0023", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0024, Name = "山田太郎", Password = "Yama0024", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0025, Name = "大西秀宜", Password = "Ooni0025", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0026, Name = "藤原裕香", Password = "Fuji0026", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0027, Name = "安部沙織", Password = "Abee0027", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0028, Name = "向井奈緒子", Password = "Muka0028", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0029, Name = "大場秀宜", Password = "Ooba0029", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0030, Name = "谷口雅宏", Password = "Tani0030", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0031, Name = "松尾戴三", Password = "Mats0031", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0032, Name = "山村昭彦", Password = "Yama0032", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0033, Name = "村上晴彦", Password = "Mura0033", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0034, Name = "小池陽子", Password = "Koik0034", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0035, Name = "金子勝弘", Password = "Kane0035", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0036, Name = "新谷護", Password = "Aray0036", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0037, Name = "黒沢信也", Password = "Kuro0037", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0038, Name = "川崎純太", Password = "Kawa0038", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0039, Name = "金田彦好", Password = "Kane0039", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0040, Name = "清水宏季", Password = "Shim0040", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0041, Name = "秋田政年", Password = "Akit0041", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0042, Name = "高井康次", Password = "Taka0042", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0043, Name = "川島十志夫", Password = "Kawa0043", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0044, Name = "藤村義子", Password = "Fuji0044", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0045, Name = "柴田正次", Password = "Shib0045", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0046, Name = "山田太郎", Password = "Yama0046", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0047, Name = "大西秀宜", Password = "Ooni0047", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0048, Name = "中西信好", Password = "Naka0048", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0049, Name = "藤村義子", Password = "Fuji0049", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0050, Name = "池田百合子", Password = "Iked0050", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0051, Name = "水谷仁美", Password = "Mizu0051", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0052, Name = "中村賢一", Password = "Naka0052", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0053, Name = "高田麻美", Password = "Taka0053", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0054, Name = "伊藤宏明", Password = "Itou0054", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0055, Name = "吉田宏明", Password = "Yosh0055", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0056, Name = "池田正明", Password = "Iked0056", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0057, Name = "清水裕也", Password = "Shim0057", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0058, Name = "早川和也", Password = "Haya0058", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0059, Name = "田中尚孝", Password = "Tana0059", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0060, Name = "土井徹", Password = "Doii0060", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0061, Name = "遠藤幸夫", Password = "Endo0061", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0062, Name = "下田雄一", Password = "Shim0062", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0063, Name = "吉村亜希子", Password = "Yosh0063", IsEmployee = false, Sonzai_Id = 1});
                _context.Users.Add(new User { Id = 0064, Name = "篠原真希", Password = "Shin0064", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0065, Name = "青木亜耶", Password = "Aoki0065", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0066, Name = "高橋真也", Password = "Taka0066", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0067, Name = "藤澤由紀", Password = "Fuji0067", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0068, Name = "遠藤真之", Password = "Endo0068", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0069, Name = "川端武", Password = "Kawa0069", IsEmployee = false, Sonzai_Id = 1 });
                _context.Users.Add(new User { Id = 0070, Name = "友寄隆利", Password = "Tomo0070", IsEmployee = false, Sonzai_Id = 1 });
                _context.SaveChanges();
          }
        }
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            var authorizedEmployee = _context.Users.SingleOrDefault(x => x.Name == user.Name && x.Password == user.Password);
            if (authorizedEmployee == null)
            {
                return NotFound();
            }
            return authorizedEmployee;
        }
    }
}