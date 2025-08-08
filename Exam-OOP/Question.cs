using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Ansawerlist { get; set; }
        public Answer RightAnswer { get; set; }
        public Question(string header, string body, int mark , Answer[] answers, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Ansawerlist = answers;
            RightAnswer = rightAnswer;

        }
        public abstract void showQuestion();
        public override string ToString()
        {
            return $"Header: {Header}, Body: {Body}, Mark: {Mark}";
        }
        public object Clone()
        {
           return this.MemberwiseClone();

        }

        public int CompareTo(Question? other)
        {
            return this.Mark.CompareTo(other?.Mark ?? 0);
        }
    }
}
