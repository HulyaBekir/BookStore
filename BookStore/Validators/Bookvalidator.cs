using BookStore.Models;
using BookStore.Models.Models.Requests;
using FluentValidation;

namespace BookStore.Validators
{
    public class Bookvalidator : AbstractValidator<Book>
    {
        public Bookvalidator()
        {
            RuleFor(x => x.AuthorId).NotNull().GreaterThan(0);
            RuleFor(x => x.Title).NotNull().MinimumLength(3);
            RuleFor(x => x.ReleaseDate).NotNull().LessThan(new DateTime(2002, 07, 11));
        }
    }
}
