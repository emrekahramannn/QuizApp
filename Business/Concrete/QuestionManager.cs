using Business.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        List<IQuestion> _questions;
        public QuestionManager()
        {
            _questions = new List<IQuestion>();
        }
        public void AddQuestion(IQuestion question)
        {
            _questions.Add(question);
        }

        public void DeleteQuestion(IQuestion question)
        {
            IQuestion questionToDelete = _questions.SingleOrDefault(q => q.Id == question.Id);
            _questions.Remove(questionToDelete);
        }

        public void UpdateQuestion(IQuestion question)
        {
            IQuestion questionToUpdate = _questions.SingleOrDefault(q => q.Id == question.Id);
            questionToUpdate.QuestionText = question.QuestionText;
            questionToUpdate.Choices = question.Choices;
            questionToUpdate.Answer = question.Answer;
        }

        public List<IQuestion> GetAllQuestions()
        {
            return _questions;
        }
    }
}
