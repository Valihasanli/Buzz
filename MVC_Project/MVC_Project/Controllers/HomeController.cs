using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using MVC_Project.Controllers.DAL;
using MVC_Project.Models;


namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

        {
            AppDbContext _dbContext;
            
            Card card1 = new Card()
            {
                CardName = "Backend Developer",
                BgImageUrl = "https://ddi-dev.com/uploads/developer-responsebilities.png",
                Desctiption = "AI hamimizi qirajax"
            };
            Card card2 = new Card()
            {
                CardName = "Frontend Developer",
                BgImageUrl = " https://th.bing.com/th/id/OIP.xLLNs3q5jrXLUGD0CMRJbAHaHa?w=187&h=187&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                Desctiption = "AI bizi qirib uje"
            };
            List<Card> cards = new List<Card>();
            cards.Add(card1);
            cards.Add(card2);

            return View(cards);
        }
        
    }
}
