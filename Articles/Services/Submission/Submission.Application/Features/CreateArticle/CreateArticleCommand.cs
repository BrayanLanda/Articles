using Articles.Abstractions;
using ArticlesAbstractions;
using FluentValidation;
using MediatR;

namespace Submission.Application.Features.CreateArticle
{
    public record CreateArticleCommand(int JourneyId, string Title, string Scope, ArticleType ArticleType) : IRequest<IdResponse>
    {
    }

    public class CreateArticleCommandValidator : AbstractValidator<CreateArticleCommand>
    {
        public CreateArticleCommandValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title connont be empty");
            RuleFor(x => x.Scope).NotEmpty().WithMessage("Scope cannont be empty");
            RuleFor(x => x.JourneyId).GreaterThan(0).WithMessage("Invalid journal id");
        }
    }
}
