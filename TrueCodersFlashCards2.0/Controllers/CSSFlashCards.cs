using Microsoft.AspNetCore.Mvc;

namespace TrueCodersFlashCards_NO_DB_.Controllers
{
    public class CSSFlashCards : Controller
    {
        private readonly ICSharpFlashCardsrepo repo;

        public CSSFlashCards(ICSharpFlashCardsrepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var flashcards = repo.GetCSSFlashCards();

            return View(flashcards);
        }

    }
}
