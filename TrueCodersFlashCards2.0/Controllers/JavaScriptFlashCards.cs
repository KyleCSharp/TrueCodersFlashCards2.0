using Microsoft.AspNetCore.Mvc;

namespace TrueCodersFlashCards_NO_DB_.Controllers
{
    public class JavaScriptFlashCards : Controller
    {
        private readonly ICSharpFlashCardsrepo repo;

        public JavaScriptFlashCards(ICSharpFlashCardsrepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var flashcards = repo.GetJavaScriptFlashCards();

            return View(flashcards);
        }

    }
}
