using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Interview.Models
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<string> Answers { get; set; }
        public int RowID { get; set; }
        public string ActualAnswer { get; set; }
        public string UserAnswer { get; set; }
        public bool FirstQuestion { get; set; }
        public bool LastQuestion { get; set; }
    }
}