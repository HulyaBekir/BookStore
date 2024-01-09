using BookStore.Models.Models.Requests;
using FluentValidation;

namespace BookStore.Validators
{
    public class GetBookByAuthorRequestValidator : AbstractValidator<GetBookByAuthorRequest>
    {
        public GetBookByAuthorRequestValidator()
        {
            RuleFor(test => test.Id)
                .NotNull()
                .GreaterThan(0)
                .LessThan(10);
            RuleFor(test => test.AfterDate)
                .NotNull()
                .NotEmpty()
                .LessThan(new DateTime(2019, 04, 20));
            
        }
    }
}
