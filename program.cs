
using System;
namespace nada;
public class Person
{
	private string _name;
	public string Name{
		get{return _name;}
		set{
            if(name == null || name== "" || name.Lenght >=32){
			throw new Exception ("InValid Name");	
		}
		_name=name;
		}
	}
	private int _age;
	public int Age{
		get{return _age;}
		set{
            if(year<=0 || year>128){
			throw new Exception ("InValid Age");	
		}
		_age=age;
		}
	}
	public Person(string name,int age){
		Name=name;
		Age=age;
		}

public  void Print(){
	Console.WriteLine("$my name:{Name}, my age: {Age}");
}
}
public class Student : Person
{
       private int _year;
	   public int Year{
		get{return _year;}
		set{
            if(year<1 || year>5){
			throw new Exception ("InValid Year");	
		}
		_year=year;
		}
	   }

	private float _gpa;   
	public float Gpa{
		get{return _gpa;}
		set{
             if(gpa<0 && gpa>4){
			throw new Exception ("InValid  Gpa");	
		}
		_gpa=gpa;
		}
	}

	public Student(string name,int age,int year,float gpa):base(name,age)
	{
		
	Year=year;
	Gpa=gpa;
	}
	public virtual void Print()
	{
	Console.WriteLine("My name is " + Name + ", my age is " + Age +" and my gpa is " +Gpa);
	}
	}
	//////staff
	public class Staff : Person
	{
	private double _salary;
	public double Salary{
		 get {
			return _salary;
		 }
		 set{
			if(salary<0 || salary>120000){
				throw new Exception ("InValid Year");	
		}
		_salary=salary;
		 }
	}
	private int _joinyear;
	public int JoinYear{
			 get {
			return _joinyear;
		 }
		 set{
			var res=2022-Age;
			if(joinyear <= (2022 -res)){
				throw new Exception ("InValid Gpa");	
		}
		_joinyear=joinyear;
		 }
	}

	public Staff(string name,int age,double salary,int joinyear) : base(name,age)
	{
		
		
	Salary=salary;
	JoinYear=joinyear;
	}
	public  virtual void Print()
{
     	Console.WriteLine("My name is " + Name + ", my age is " + Age +" and my salary is " +Salary);
	}
	}
public class Database{
	 private int _index;
     public Person[] People= new Person[50];

  public void AddStudent(Student student){
   People[_index++] = student;
   }
    public void AddStaff(Staff staff){
      People[_index++] = staff;
 }
     public void AddPerson(Person person){
      People[_index++] = person;
 }

 public void printAll()
 {
 for(int i=0;i<=_index;i++){
 People[i].Print;
 }
 }}
public class nada{
	public static void Main()
	{
		var database= new Database();
		string name= Console.ReadLine();
		int age= Convert.ToInt32(Console.ReadLine());
		int year= Convert.ToInt32(Console.ReadLine());
		int gpa= Convert.ToSingle(Console.ReadLine());
		
		var student=new Student(name,age,year,gpa);
		database.AddStudent(student);
		
		////staff
		double salary= Convert.ToDouble(Console.ReadLine());
		int joinyear= Convert.ToInt32(Console.ReadLine());
		
	     var staff=new Staff(name,age,salary,joinyear);
		database.AddStaff(staff);
		
		
		while(true){
			Console.WriteLine("option: ");
			var option=Convert.ToInt32(Console.ReadLine());
			switch(option){
				case 1:
					Console.WriteLine("Name: ");
					var name1=Console.WriteLine();
					Console.WriteLine("Age: ");
					var age1=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Year: ");
					var year= Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Gpa: ");
					var gpa= Convert.ToSingle(Console.ReadLine());
					 try{
					var student=new Student(name1,age1,year,gpa);
		                          database.AddStudent(student);
					 }
					 catch(Exception e)
					 {
						 Console.WriteLine(e.Message);
					 }
					break;
				case 2:	
				    Console.WriteLine("Name: ");
					var name2=Console.ReadLine();
					Console.WriteLine("Age: ");
					var age2=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Salary: ");
					var salary= Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("JoinYear: ");
					var joinyear= Convert.ToInt32(Console.ReadLine());
			         try{
					var staff=new Staff(name2,age2,salary,joinyear);
		                        database.AddStaff(staff);
					 }
					 catch(Exception e)
					 {
						 Console.WriteLine(e.Message);
					 }
					
	                                  
					break;
				case 3:
				        Console.WriteLine("Name: ");
					var name3=Console.ReadLine();
					Console.WriteLine("Age: ");
					var age3=Convert.ToInt32(Console.ReadLine());
                      
					     try{
				var person=new Person(name3,age3);
					database.AddPerson(person);
					 }
					 catch(Exception e)
					 {
						 Console.WriteLine(e.Message);
					 }
				
					
					break;
				case 4:
					database.PrintAll();
					break;
				default:
					return;
			}
			}
			
		
	}}
