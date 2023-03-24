using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace TrueCodersFlashCards_NO_DB_.Controllers
{
    public class C_FlashCards : Controller
    {
       private readonly ICSharpFlashCardsrepo repo;

        public C_FlashCards(ICSharpFlashCardsrepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var flashcards = repo.GetCFlashCards();

            return View(flashcards);
        }   

    }
}
