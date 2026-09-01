using Articles.Abstractions;
using ArticlesAbstractions.Enums;

namespace Submission.Domain.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Scope { get; set; }
        public ArticleType Type { get; set; }
        public ArticleStage Stage { get; internal set; }
        public int JournalId { get; init; }
        public Journal Journal { get; init; }
    }
}
