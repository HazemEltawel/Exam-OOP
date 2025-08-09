using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class TFQuestion : Question
    {
        public TFQuestion(string header, string body, int mark)
        : base(header, body, mark)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"{Header}\n{Body} ({Mark} marks)");
            foreach (var answer in Answers)
            {
                Console.WriteLine(answer);
            }
        }
    }
}
