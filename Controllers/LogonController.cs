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
            if (_context.Employees.Count() == 0)
            {
                _context.Employees.Add(new Employee { Id = 0001, Name = "比嘉　哲平", Password = "Higa0001", IsEmployee = true, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0002, Name = "山田　慎一", Password = "Yama0002", IsEmployee = true, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0003, Name = "金城　まゆみ", Password = "Kinj0003", IsEmployee = true, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0004, Name = "高木　弘樹", Password = "Taka0004", IsEmployee = true, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0005, Name = "小山　育雄", Password = "Koya0005", IsEmployee = true, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0006, Name = "田原　美由紀", Password = "Taha0006", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0007, Name = "知念　雅人", Password = "Chie0007", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0008, Name = "山城　亮介", Password = "Yama0008", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0009, Name = "比嘉　暉一郎", Password = "Higa0009", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0010, Name = "安田　千絵子", Password = "Yasu0010", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0011, Name = "下地　綾乃", Password = "Shim0011", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0012, Name = "平良　祐作", Password = "Tair0012", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0013, Name = "前川　博", Password = "Maek0013", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0014, Name = "藤川　裕香", Password = "Fuji0014", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0015, Name = "新谷　沢子", Password = "Shin0015", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0016, Name = "鈴木　一郎", Password = "Suzu0016", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0017, Name = "田中　五郎", Password = "Than0017", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0018, Name = "城間　真澄", Password = "Shir0018", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0019, Name = "足立　康史", Password = "Adac0019", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0020, Name = "武藤　純子", Password = "Muto0020", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0021, Name = "西野　大夢", Password = "Nisi0021", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0022, Name = "山根　秀次郎", Password = "Yama0022", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0023, Name = "丹羽　佑治", Password = "Tanb0023", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0024, Name = "山田　太郎", Password = "Yama0024", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0025, Name = "大西　秀宜", Password = "Ooni0025", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0026, Name = "藤原　裕香", Password = "Fuji0026", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0027, Name = "安部　沙織", Password = "Abee0027", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0028, Name = "向井　奈緒子", Password = "Muka0028", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0029, Name = "大場　秀宜", Password = "Ooba0029", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0030, Name = "谷口　雅宏", Password = "Tani0030", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0031, Name = "松尾　戴三", Password = "Mats0031", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0032, Name = "山村　昭彦", Password = "Yama0032", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0033, Name = "村上　晴彦", Password = "Mura0033", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0034, Name = "小池　陽子", Password = "Koik0034", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0035, Name = "金子　勝弘", Password = "Kane0035", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0036, Name = "新谷　護", Password = "Aray0036", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0037, Name = "黒沢　信也", Password = "Kuro0037", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0038, Name = "川崎　純太", Password = "Kawa0038", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0039, Name = "金田　彦好", Password = "Kane0039", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0040, Name = "清水　宏季", Password = "Shim0040", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0041, Name = "秋田　政年", Password = "Akit0041", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0042, Name = "高井　康次", Password = "Taka0042", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0043, Name = "川島　十志夫", Password = "Kawa0043", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0044, Name = "藤村　義子", Password = "Fuji0044", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0045, Name = "柴田　正次", Password = "Shib0045", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0046, Name = "山田　太郎", Password = "Yama0046", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0047, Name = "大西　秀宜", Password = "Ooni0047", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0048, Name = "中西　信好", Password = "Naka0048", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0049, Name = "藤村　義子", Password = "Fuji0049", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0050, Name = "池田　百合子", Password = "Iked0050", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0051, Name = "水谷　仁美", Password = "Mizu0051", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0052, Name = "中村　賢一", Password = "Naka0052", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0053, Name = "高田　麻美", Password = "Taka0053", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0054, Name = "伊藤　宏明", Password = "Itou0054", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0055, Name = "吉田　宏明", Password = "Yosh0055", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0056, Name = "池田　正明", Password = "Iked0056", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0057, Name = "清水　裕也", Password = "Shim0057", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0058, Name = "早川　和也", Password = "Haya0058", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0059, Name = "田中　尚孝", Password = "Tana0059", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0060, Name = "土井　  徹", Password = "Doii0060", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0061, Name = "遠藤　幸夫", Password = "Endo0061", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0062, Name = "下田　雄一", Password = "Shim0062", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0063, Name = "吉村　亜希子", Password = "Yosh0063", IsEmployee = false, Sonzai_Id = 1});
                _context.Employees.Add(new Employee { Id = 0064, Name = "篠原　真希", Password = "Shin0064", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0065, Name = "青木　亜耶", Password = "Aoki0065", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0066, Name = "高橋　真也", Password = "Taka0066", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0067, Name = "藤澤　由紀", Password = "Fuji0067", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0068, Name = "遠藤　真之", Password = "Endo0068", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0069, Name = "川端　  武", Password = "Kawa0069", IsEmployee = false, Sonzai_Id = 1 });
                _context.Employees.Add(new Employee { Id = 0070, Name = "友寄　隆利", Password = "Tomo0070", IsEmployee = false, Sonzai_Id = 1 });
                _context.SaveChanges();
          }
        }
        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            var authorizeEmployee = _context.Employees.SingleOrDefault(x => x.Id == employee.Id  &&   x.Password == employee.Password );
            if (authorizeEmployee == null || employee.Sonzai_Id == 0)
            {
                return NotFound();
            }
            return authorizeEmployee;
        }
    }
}