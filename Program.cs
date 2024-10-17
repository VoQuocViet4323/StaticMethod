internal class Program
{
    private static void Main(string[] args)
    {
        Student.Change();
        Student s1 = new Student(1, "Viet");
        Student s2 = new Student(2, "Vu");
        Student s3 = new Student(3, "Chien");

        s1.Display();
        s2.Display();
        s3.Display();
    }
}