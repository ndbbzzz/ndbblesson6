using Microsoft.AspNetCore.Mvc;
using ndbblesson6.Models.DataModels;

namespace ndbblesson6.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            
                var member = new Member();

                member.MemberId = Guid.NewGuid().ToString();
                member.Username = "NguyenDucBaoBinh";
                member.Password = "password";
                member.Fullname = "Bao Binh";
                member.Email = "ndbb7112006@gmail.com";

                ViewBag.member = member;

                return View(member);
            }
        public static readonly List<Member> members = new List<Member>()
{
    new Member
    {
        MemberId = Guid.NewGuid().ToString(),
        Username = "member1",
        Fullname = "Thành viên 1",
        Password = "123456",
        Email = "tv1@gmail.com"
    },
    new Member
    {
        MemberId = Guid.NewGuid().ToString(),
        Username = "member2",
        Fullname = "Thành viên 2",
        Password = "123456",
        Email = "tv2@gmail.com"
    },
    new Member
    {
        MemberId = Guid.NewGuid().ToString(),
        Username = "member3",
        Fullname = "Thành viên 3",
        Password = "123456",
        Email = "tv3@gmail.com"
    },
    new Member
    {
        MemberId = Guid.NewGuid().ToString(),
        Username = "member4",
        Fullname = "Thành viên 4",
        Password = "123456",
        Email = "tv4@gmail.com"
    },
    new Member
    {
        MemberId = Guid.NewGuid().ToString(),
        Username = "member5",
        Fullname = "Thành viên 5",
        Password = "123456",
        Email = "tv5@gmail.com"
    }
};

        public IActionResult GetMembers()
        {
            ViewBag.members = members;

            return View();
        }

        // Default là GET
        public IActionResult Create()
        {
            return View();
        }

        // HttpPost là POST, nhận dữ liệu từ form
        [HttpPost]
        public IActionResult Create(Member member)
        {
            member.MemberId = Guid.NewGuid().ToString();

            members.Add(member);

            return RedirectToAction("GetMembers");
        }
    }
 
        }
 