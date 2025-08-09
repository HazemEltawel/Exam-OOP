using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public List<Answer> Answers { get; set; } = new List<Answer>();

        public Answer RightAnswer { get; set; }

        public Question(string header, string body, int mark, Answer[] answers, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            RightAnswer = rightAnswer;
        }

        protected Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public abstract void Show();
    }
}
