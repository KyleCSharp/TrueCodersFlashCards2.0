using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace TrueCodersFlashCards_NO_DB_.Controllers
{
    public class CSharpFlashCards : Controller
    {
       private readonly ICSharpFlashCardsrepo repo;

        public CSharpFlashCards(ICSharpFlashCardsrepo repo)
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
