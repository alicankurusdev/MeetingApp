using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Conttrollers
{


    public class HomeController : Controller
    {
        //localhost:/
        public IActionResult Index()
        {

            int saat = DateTime.Now.Hour;

            //ViewBag.Selamlama = saat > 12 ? "IYI GUNLER" : "GUNAYDIN";

            ViewData["Selamlama"] = saat > 12 ? "GOOD AFTERNOon" : "GOOD MORNING";
            int UserCount = Repository.Users.Where(i => i.Participation == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Abc Kongre merkezi ,istanbul ",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount
            };


            return View(meetingInfo);
        }
    }




}