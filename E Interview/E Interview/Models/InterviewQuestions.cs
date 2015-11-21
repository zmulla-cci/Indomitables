using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Interview.Models
{
    public static class InterviewQuestions
    {
        public static List<Question> Questions { get; set; }

        public static bool IsComplete { get; set; }

        public static void SetInterviewQuestions()
        {
            Questions = new List<Question>();
            Question q = new Question();

            q.QuestionText = "1.Which of the following statements are TRUE about the .NET CLR?";
            q.Answers = new List<string>() { "It provides a language-neutral development & execution environment. ", "It ensures that an application would not be able to access memory that it is not authorized to access. ", "It provides services to run managed applications. ", "The resources are garbage collected. " };
            q.RowID = 1;
            q.FirstQuestion = true;

            Questions.Add(q);

            q = new Question();

            q.QuestionText = "2.Which of the following are valid .NET CLR JIT performance counters?";
            q.Answers = new List<string>() { "Total memory used for JIT compilation ", "Average memory used for JIT compilation ", "Number of methods that failed to compile with the standard JIT ", "Percentage of processor time spent performing JIT compilation " };
            q.RowID = 2;

            Questions.Add(q);

            q = new Question();

            q.QuestionText = "3.Which of the following statements is correct about Managed Code?";
            q.Answers = new List<string>() { "Managed code is the code that is compiled by the JIT compilers.", "Managed code is the code where resources are Garbage Collected.", "Managed code is the code that runs on top of Windows.", "Managed code is the code that is written to target the services of the CLR." };
            q.RowID = 3;

            Questions.Add(q);

            q = new Question();

            q.QuestionText = "4.Which of the following utilities can be used to compile managed assemblies into processor-specific native code?";
            q.Answers = new List<string>() { "gacutil", "ngen", "ildasm", "dumpbin" };
            q.RowID = 4;

            Questions.Add(q);

            q = new Question();

            q.QuestionText = "5.Which of the following jobs are NOT performed by Garbage Collector?";
            q.Answers = new List<string>() { "Freeing memory on the stack.", "Avoiding memory leaks.", "reeing memory occupied by unreferenced objects.", "Closing unclosed database collections." };
            q.RowID = 5;
            q.LastQuestion = true;

            Questions.Add(q);

            InterviewQuestions.Questions = Questions;
        }
    }
}