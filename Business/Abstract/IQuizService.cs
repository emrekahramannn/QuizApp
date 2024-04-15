using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IQuizService
    {
        IQuestion GetQuestion();
        void DisplayQuestion();
        void Guess(string answer);
        void LoadQuestion();
        void ShowScore();
        void DisplayProgress();
    }
}
