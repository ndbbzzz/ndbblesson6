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
        public IActionResult GetMembers()
        {
            List<Member> members = new List<Member>();

            members.Add(new Member
            {
                MemberId = Guid.NewGuid().ToString(),
                Username = "member1",
                Fullname = "Thành viên 1",
                Password = "123456",
                Email = "tv1@gmail.com"
            });

            members.Add(new Member
            {
                MemberId = Guid.NewGuid().ToString(),
                Username = "member2",
                Fullname = "Thành viên 2",
                Password = "123456",
                Email = "tv2@gmail.com"
            });

            members.Add(new Member
            {
                MemberId = Guid.NewGuid().ToString(),
                Username = "member3",
                Fullname = "Thành viên 3",
                Password = "123456",
                Email = "tv3@gmail.com"
            });

            members.Add(new Member
            {
                MemberId = Guid.NewGuid().ToString(),
                Username = "member4",
                Fullname = "Thành viên 4",
                Password = "123456",
                Email = "tv4@gmail.com"
            });

            members.Add(new Member
            {
                MemberId = Guid.NewGuid().ToString(),
                Username = "member5",
                Fullname = "Thành viên 5",
                Password = "123456",
                Email = "tv5@gmail.com"
            });

            ViewBag.members = members;

            return View();
        }
    }
 
        }
 