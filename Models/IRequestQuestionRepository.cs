using System.Linq;

namespace IParse.Models
{
    public interface IRequestQuestionRepository
    {
        public IQueryable<RequestQuestion> RequestQuestions { get; }
        public void SaveRequestQuestion(RequestQuestion requestQuestion);
    }
}