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
        public ArticleStage Stage { get; set; }
        public int JournalId { get; set; }
        public Journal Journal { get; set; }
        //test
    }
}
