namespace School_magazine;

public class Student
{
    public string FullName { get; set; }
    public string Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public int Age => DateTime.Now.Year - BirthDate.Year;
    public double Grade { get; set; }
    public bool IsExpelled { get; set; }
    public bool HasDebt { get; set; }
}