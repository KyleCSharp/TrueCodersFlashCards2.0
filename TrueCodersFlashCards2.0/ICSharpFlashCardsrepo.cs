using TrueCodersFlashCards_NO_DB_.Models;

namespace TrueCodersFlashCards_NO_DB_
{
    public interface ICSharpFlashCardsrepo
    {
        public IEnumerable<FlashCard> GetCFlashCards();
        public IEnumerable<FlashCard> GetCSSFlashCards();

        public IEnumerable<FlashCard> GetHTMLFlashCards();
        public IEnumerable<FlashCard> GetSQLFlashCards();
        public IEnumerable <FlashCard> GetJavaScriptFlashCards();
    }
}
