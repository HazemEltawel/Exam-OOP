using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class FinalExam : Exam
    {
        public FinalExam (int time, int numberqustion) : base(time, numberqustion)
        {
        }
        public override void ShowExam()
        {
            int total = 0;
            Console.WriteLine($"Final Exam: Time - {time} minutes, Number of Questions - {numberqustion}");
            foreach (var q in questions)
            {
                q.showQuestion();
                Console.Write("Enter your answer ID: ");
                int answerId =int.Parse(Console.ReadLine());
                if (q.RightAnswer.AnswerId == ansId )
                    total += q.Mark;

            }
            Console.WriteLine($"Total Marks: {total}");
        }
    }
}
