using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Exam_OOP
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions) 
        {
        }
        public override void ShowExam()
        {
            int questionNumber = 1; 
            int studentGrade = 0;   

            foreach (var question in Questions)
            {
                Console.WriteLine($"Q{questionNumber}: {question.Header}"); 
                Console.WriteLine($"{question.Body}");                   

                foreach (var answer in question.Answers)
                {
                    Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
                }

                Console.Write("Your Answer: ");
                string userInput = Console.ReadLine();

                if (question.RightAnswer != null && userInput.ToLower() == question.RightAnswer.AnswerId.ToString().ToLower())
                {
                    studentGrade += question.Mark; 
                }

                Console.WriteLine(new string('-', 50)); 
                questionNumber++;
            }

            Console.WriteLine($"Your final grade is: {studentGrade} out of {Questions.Sum(q => q.Mark)}");
        }
    }
}
