using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IQuestionService
    {
        void AddQuestion(IQuestion question);
        void DeleteQuestion(IQuestion question);    
        void UpdateQuestion(IQuestion question);
        List<IQuestion> GetAllQuestions();
    }
}
