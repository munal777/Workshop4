using System;

class Program
{
    static void Main(String[] args)
    {
        Student student1 = new Student("Munal", "Poudel", 22);
        Student student2 = new Student("Nikesh", "Shah", 22);

        Console.WriteLine($"{Student.CollageName} student's - {student1.firstname} {student1.lastname} & his age is {student1.age}");
        Console.WriteLine($"{Student.CollageName} student's - {student2.firstname} {student2.lastname} & his age is {student2.age}");
    }
}