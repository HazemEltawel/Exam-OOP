using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions)
        : base(time, numberOfQuestions)  
        {
        }
        public override void ShowExam() 
        {
            int questionNumber = 1;

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


                Console.WriteLine($"Correct Answer: {question.RightAnswer.AnswerId}. {question.RightAnswer.AnswerText}");
                Console.WriteLine(new string('-', 50));

                questionNumber++;
            }
        }
    }
}
