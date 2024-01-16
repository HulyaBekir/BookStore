using BookStore.Models;
using BookStore.Users.Models;
using FluentValidation;

namespace BookStore.Validators
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();
        }
    }
}
