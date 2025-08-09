using Exam_OOP;
class program
{
    static void Main(string[] args)
    {
        
        Subject mySubject = new Subject(1, "OOP");
        Exam exam = new FinalExam(60, 2); 

        Question q1 = new MCQQuestion("What is OOP?", "Choose the correct answer", 5);
        q1.Answers.Add(new Answer("a", "Object Oriented Programming"));
        q1.Answers.Add(new Answer("b", "Old Order Processing"));
        q1.Answers.Add(new Answer("c", "Online Open Protocol"));
        q1.RightAnswer = q1.Answers[0];
        
        Question q2 = new TFQuestion("Polymorphism allows one interface, many implementations.", "True or False?", 5);
        q2.Answers.Add(new Answer("a", "True"));
        q2.Answers.Add(new Answer("b", "False"));
        q2.RightAnswer = q2.Answers[0];
        
        exam.Questions.Add(q1);
        exam.Questions.Add(q2);
        
        mySubject.Exam = exam;
        
        mySubject.Exam.ShowExam(); 
    }
}
