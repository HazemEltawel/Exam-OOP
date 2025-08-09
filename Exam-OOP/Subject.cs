using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class Subject
    {
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public Exam SubjectExam { get; set; }
        public Exam Exam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;      
            SubjectName = subjectName;   
        }

        public void CreateExam(Exam exam)
        {
            SubjectExam = exam; 
        }
        public override string ToString()
        {
            return $"Subject ID: {SubjectId}, Subject Name: {SubjectName}";
        }
    }
}
