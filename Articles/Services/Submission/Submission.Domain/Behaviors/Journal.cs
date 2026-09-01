using Articles.Abstractions;

namespace Submission.Domain.Entities
{
    public partial class Journal
    {
        public Article CreateArticle(string title, ArticleType Type, string scope)
        {
            var article = new Article()
            {
                Title = title,
                Type = Type,
                Scope = scope,
                Journal = this,
                Stage = ArticlesAbstractions.Enums.ArticleStage.Created
            };
            _articles.Add(article);
            //TODO
            return article;
        }
    }
}
