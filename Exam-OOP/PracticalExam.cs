using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberqustion) : base(time, numberqustion)
        {
        }
        public override void ShowExam()
        {
            
            Console.WriteLine($"Practical Exam: Time - {time} minutes, Number of Questions - {numberqustion}");
            foreach (var q in questions)
            {
                q.showQuestion();
                Console.Write("Enter your answer ID: ");
                int ansId = int.Parse(Console.ReadLine());            
            }
            Console.WriteLine($"Correct Answer: {q.RightAnswer.AnswerText}\n");
        }
    }
}
