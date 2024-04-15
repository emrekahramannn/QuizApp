using Business.Abstract;
using Business.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuestionService questionService = new QuestionManager();
            questionService.AddQuestion(new Question(1, "What is the best programming language in 2023 ?", ["C#", "Python", "Java", "Javascript"], "a"));
            questionService.AddQuestion(new Question(2, "What is the most popular programming language in 2023?", ["Python", "Java", "C#", "Javascript"], "a"));
            questionService.AddQuestion(new Question(3, "What is the most user-friendly programming language ?", ["C#", "Java", "Python", "Javascript"], "d"));
            questionService.AddQuestion(new Question(4, "What is the most loved programming language ?", ["C#", "Python", "Java", "Javascript"], "b"));


            

            // questionService.UpdateQuestion(new Question(1, "What is the best programming language in 2023 ?", ["C#", "Python", "Java", "Javascript"], "b"));
            // questionService.DeleteQuestion(new Question { Id = 3});

            QuizManager quizService = new QuizManager(questionService.GetAllQuestions());
            quizService.LoadQuestion();
        }
    }
}