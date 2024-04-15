using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Question : IQuestion
    {
        public Question()
        { 
            
        }

        public Question(int id, string question, string[] choices, string answer)
        {
            Id = id;
            QuestionText = question;
            Choices = choices;
            Answer = answer;
        }
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string[] Choices { get; set; }
        public string Answer {  get; set; }
    }
}
