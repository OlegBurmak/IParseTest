using System.Linq;

namespace IParse.Models
{
    public class EFRequestQuestionRepository : IRequestQuestionRepository
    {
        private ApplicationDbContext context;

        public EFRequestQuestionRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<RequestQuestion> RequestQuestions => context.RequestQuestions;

        public void SaveRequestQuestion(RequestQuestion requestQuestion)
        {
            context.AttachRange(requestQuestion);
            if(requestQuestion.RequestQuestionId == 0)
            {
                context.RequestQuestions.Add(requestQuestion);
            }
            context.SaveChanges();
        }
    }
}