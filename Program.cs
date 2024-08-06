using System;
using System.Runtime.CompilerServices;


internal class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new()
        {
            Name = "Burak",
            SurName = "Kırıcı",
            Id = 1017
        };
       

        Ogretmen ogretmen = new()
        {
            Name = "Burak",
            SurName = "DahaKırıcı",
            Earnings = 129
           
        };
        ogretmen.WriteInfo();
        ogrenci.WriteInfo();
   
    }
}
public abstract class BaseKisi
{
    public string Name { get; set; }
    public string SurName { get; set; }
    abstract public void WriteInfo();
}
public class Ogrenci : BaseKisi
{
    public int Id { get; set; }
    public override void WriteInfo()
    {
        Console.WriteLine("Student Name: " + " " + Name + " " + "Surname: " + " " +SurName + " Student ID Number: " + " " + Id);
    }

}
public class Ogretmen : BaseKisi
{
    public decimal Earnings { get; set; }

    public override void WriteInfo()
    {
        Console.WriteLine("Salary: " + " " + Earnings + " " + "Teacher Name: " + " " + Name + " " + "Teacher Surname: " + " " + SurName);
    }
    

}
