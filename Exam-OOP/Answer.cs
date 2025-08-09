using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class Answer
    {
        public string AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(string id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }

        public override string ToString()
        {
            return $"{AnswerId}: {AnswerText}";
        }
    }
}
