using Business.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class QuizManager : IQuizService
    {
        List<IQuestion> _questions;
        int _score = 0, _questionIndex = 0;
        public QuizManager(List<IQuestion> questions) 
        {
            _questions = questions;
        }

        public IQuestion GetQuestion()
        {
            return _questions[_questionIndex];
        }

        public void DisplayQuestion()
        {
            IQuestion question = GetQuestion();
            Console.WriteLine($"Question {_questionIndex +1}: {question.QuestionText}");

            foreach(var choice in question.Choices)
            {
                Console.WriteLine("-" + choice);
            }

            Console.Write("Answer: ");
            string answer = Console.ReadLine();
            Guess(answer);
            LoadQuestion();
        }

        public void Guess(string answer)
        {
            IQuestion question = GetQuestion();
            if (question.Answer == answer) 
            {
                _score++;
            }
            _questionIndex++;
        }

        public void LoadQuestion()
        {
            if(_questions.Count == _questionIndex)
            {
                ShowScore();
            }
            else
            {
                DisplayProgress();
                DisplayQuestion();
            }
        }

        public void ShowScore()
        {
            Console.WriteLine($"Score:  {(_score * 100 / _questions.Count())}");
        }

        public void DisplayProgress()
        {
            int totalQuestion = _questions.Count;
            int questionNumber = _questionIndex + 1;

            if(questionNumber > totalQuestion)
            {
                Console.WriteLine("Quiz is over.");
            }
            else
            {
                Console.WriteLine($"Question {questionNumber} of {totalQuestion}");
            }
        }
    }
}
