using Microsoft.AspNetCore.Mvc;

namespace TrueCodersFlashCards_NO_DB_.Controllers
{
    public class SQLFlashCards : Controller
    {
        private readonly ICSharpFlashCardsrepo repo;

        public SQLFlashCards(ICSharpFlashCardsrepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var flashcards = repo.GetSQLFlashCards();

            return View(flashcards);
        }

    }
}
