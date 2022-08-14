using System.Collections.Generic;
using System.Text;

namespace MB.Domain.ArticleAgg.Services
{
    public interface IArticleValidatorService
    {
        void CheckThatThisRecordAlreadyExists(string title);
    }
}
