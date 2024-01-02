using BookStore.Users.Models;

namespace BookStore.Models.Models.Responses
{
    public class GetBooksByAuthorResponses
    {
        public Author  Author { get; set; }

        public List<Book> Books { get; set; }
    }
}
