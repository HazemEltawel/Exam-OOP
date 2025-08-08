using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public abstract class Exam
    {
        public int time { get; set; }
        public  int numberqustion { get; set; }
        public list<Question> questions { get; set; }
        public Exam(int time, int numberqustion)
        {
            this.time = time;
            this.numberqustion = numberqustion;
            questions = new list<Question>;
        }
        public abstract void ShowExam();

    }
}
