using System;
namespace nada;
public abstract class person
{
	public string Name;
	public int Age;
	public Person(string name,int age){
		Name=name;
		Age=age;}

public abstract void Print();
}
public class Student : Person
{
       public int Year;
	public float Gpa;
	public Student(string name;int age;int year,float gpa):base(name,age)
	{
	Year=year;
	Gpa=gpa;
	}
	public override void Print()
	{
	Console.WriteLine("My name is " + Name + ", my age is " + Age +" and my gpa is " +Gpa);
	}
	}
 public class Database{
     public int Person[] People= new Person[30];
     private int index;
     
   public void AddStudent(Student student){
   People[index] = student;
   }
 }
		   

	
public class nada{
	private static void Main()
	{
		var data= new Database();
		string name= Console.WriteLine();
		int age= 1*Console.WriteLine();
		int year= 1*Console.WriteLine();
		int gpa= 1*Console.WriteLine();
	var student=new Student(name,age,year,gpa);
		data.AddStudent(student);
	}
		
	}}
