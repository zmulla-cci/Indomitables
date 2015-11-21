using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Interview.Models
{
    public class InterviewQuestions
    {
        public List<Question> Questions { get; set; }

        public InterviewQuestions()
        {
            Questions = new List<Question>();
            Question q = new Question();

            q.QuestionText = "1.Which of the following statements are TRUE about the .NET CLR?";
            q.Answers = new List<string>() { "Only 1 and 2", "Only 1, 2 and 4", "Only 4 and 5", "Only 3 and 4" };
            q.RowID = 1;
            q.FirstQuestion = true;

            Questions.Add(q);

            q = new Question();

            q.QuestionText = "2.Which of the following statements are TRUE .NET CLR?";
            q.Answers = new List<string>() { "Only 1 and 2", "Only 1, 2 and 4", "Only 4 and 5", "Only 3 and 4" };
            q.RowID = 2;

            Questions.Add(q);

            q = new Question();

            q.QuestionText = "3.Which of the following statements are TRUE .NET CLR?";
            q.Answers = new List<string>() { "Only 1 and 2", "Only 1, 2 and 4", "Only 4 and 5", "Only 3 and 4" };
            q.RowID = 3;

            Questions.Add(q);

            q = new Question();

            q.QuestionText = "4.Which of the following statements are TRUE .NET CLR?";
            q.Answers = new List<string>() { "Only 1 and 2", "Only 1, 2 and 4", "Only 4 and 5", "Only 3 and 4" };
            q.RowID = 4;

            Questions.Add(q);

            q = new Question();

            q.QuestionText = "5.Which of the following statements are TRUE .NET CLR?";
            q.Answers = new List<string>() { "Only 1 and 2", "Only 1, 2 and 4", "Only 4 and 5", "Only 3 and 4" };
            q.RowID = 5;
            q.LastQuestion = true;

            Questions.Add(q);
        }
    }
}