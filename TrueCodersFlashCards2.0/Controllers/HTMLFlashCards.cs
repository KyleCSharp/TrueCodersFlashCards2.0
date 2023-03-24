using Microsoft.AspNetCore.Mvc;

namespace TrueCodersFlashCards_NO_DB_.Controllers
{
    public class HTMLFlashCards : Controller
    {
        private readonly ICSharpFlashCardsrepo repo;

        public HTMLFlashCards(ICSharpFlashCardsrepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var flashcards = repo.GetHTMLFlashCards();

            return View(flashcards);
        }

    }
}
