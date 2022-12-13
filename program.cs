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
	public Student(string name,int age;int year,float gpa):base(name,age)
	{
	Year=year;
	Gpa=gpa;
	}
	public override void Print()
	{
	Console.WriteLine("My name is " + Name + ", my age is " + Age +" and my gpa is " +Gpa);
	}
	}
	//////staff
	public class Staff :Person
	{
	public double Salary;
	public int JoinYear;
	public Staff(string name,int age,double salary,int joinyear) : base(name,age)
	{
	Salary=salary;
	JoinYear=joinyear;
	}
	public  override void Print()
{
     	Console.WriteLine("My name is " + Name + ", my age is " + Age +" and my salary is " +Salary);
	}
	}
public class Database{
     public int Person[] People= new Person[30];
     private int index;
     
   public void AddStudent(Student student){
   People[index] = student;
   }
    public void AddStaff(Staff staff){
      People[index] = staff;
 }
 public void printAll()
 {
 for(int i=0;i<=index;i++){
 People[i].Print
 }
 }
 
 }
		   

	
public class nada{
	private static void Main()
	{
		var data= new Database();
		string name= Console.WriteLine();
		int age= Convert.ToInt32(Console.WriteLine());
		int year= Convert.ToInt32(Console.WriteLine());
		int gpa= Convert.ToSingle(Console.WriteLine());
		
		var student=new Student(name,age,year,gpa);
		data.AddStudent(student);
		
		////staff
		double salary= Convert.Double(Console.WriteLine());
		int joinyear= Convert.ToInt32(Console.WriteLine());
		
	     var staff=new Staff(name,age,salary,joinyear);
		data.AddStaff(staff);
		
		var option=Convert.ToInt32(Console.WriteLine());
		while(true){
			switch(option){
				case 1:
					Console.WrireLine("Name: ");
					var name=Console.WriteLine();
					Console.WrireLine("Age: ");
					var age=Convert.ToInt32(Console.WriteLine());
					Console.WrireLine("Year: ");
					var year= Convert.ToInt32(Console.WriteLine());
					Console.WrireLine("Gpa: ");
					var gpa= Convert.ToSingle(Console.WriteLine());
					
					var student=new Student(name,age,year,gpa);
		                          data.AddStudent(student);
					
					break;
				case 2:	
				    Console.WrireLine("Name: ");
					var name=Console.WriteLine();
					Console.WrireLine("Age: ");
					var age=Convert.ToInt32(Console.WriteLine());
					Console.WrireLine("Salary: ");
					var salary= Convert.Double(Console.WriteLine());
					Console.WrireLine("JoinYear: ");
					var joinyear= Convert.ToInt32(Console.WriteLine());
			        
					var staff=new Staff(name,age,salary,joinyear);
		                        data.AddStaff(staff);
	                                  
					break;
				case 3:
				        Console.WrireLine("Name: ");
					var name=Console.WriteLine();
					Console.WrireLine("Age: ");
					var age=Convert.ToInt32(Console.WriteLine());
					var person=new Person(name,age);
					break;
				case 4:
					data.PrintAll();
					break;
				default:
					return;
			}
			}
			
		
	}}
