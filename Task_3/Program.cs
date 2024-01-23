

Console.WriteLine("********************************************************************************");

Student student1 = new Student();
student1.Name = "Ismoil Ghiyosov";
student1.GradeLevel = new int[] {8,7,9,8,9,10,10,8,8,10,7};
student1.Score = 85;

Console.WriteLine(student1.GetAverage());

student1.Diagram();

Console.WriteLine("********************************************************************************");

Student student2 = new Student();
student2.Name = "Ismoil Ismoil";
student2.GradeLevel = new int[] { 10, 10, 9, 10, 9, 10, 10, 10, 8, 10, 7 };
student2.Score = 92;

Console.WriteLine(student2.GetAverage());

student2.Diagram();

Console.WriteLine("********************************************************************************");

Student student3 = new Student();
student3.Name = "GHIYOSOV Ghiyosov";
student3.GradeLevel = new int[] { 8, 7, 9, 8, 9, 5, 10, 5, 8, 5, 7 };
student3.Score = 68;

Console.WriteLine(student3.GetAverage());

student3.Diagram();



Console.WriteLine("********************************************************************************");













public class Student 
{
    public string Name;
    public int[] GradeLevel = new int[11];
    public int Score;

    public int GetAverage() 
    {
        int b = 0;
        for (int i = 0; i < GradeLevel.Length; i++) b = b + GradeLevel[i];  
        return b/GradeLevel.Length;
    }

    public void Diagram() 
    {
        if (Score >=90 ) 
        {
            Console.WriteLine($"Congratulations {Name} on achieving above average scores ({Score}) in grade {GetAverage()}!\r\nKeep up the good work!");
        }
        if (Score > 80 && Score < 89) 
        {
            Console.WriteLine($"Congratulations {Name} on achieving above average scores ({Score}) in grade {GetAverage()}!\r\nKeep up the good work!");
        }
        if (Score < 80) 
        {
            Console.WriteLine($"{Name}, if you're having difficulties with your studies, don't hesitate to\r\nseek help. Your current average score is {Score} in grade {GetAverage}.");
        }
    }
}