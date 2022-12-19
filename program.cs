using System;
namespace nada;
public class Person
{
	private string _name;
	public string Name{
		get{return _name;}
		set{
            if(value == null || value== "" || value.Length >=32){
			throw new Exception ("InValid Name");	
		}
		_name=value;
		}
	}
	private int _age;
	public int Age{
		get{return _age;}
		set{
            if(value<=0 || value>128){
			throw new Exception ("InValid Age");	
		}
		_age=value;
		}
	}
	public int Getage() => _age;
	
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
            if(value<1 || value>5){
			throw new Exception ("InValid Year");	
		}
		_year=value;
		}
	   }

	private float _gpa;   
	public float Gpa{
		get{return _gpa;}
		set{
             if(value<0 && value>4){
			throw new Exception ("InValid  Gpa");	
		}
		_gpa=value;
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
			if(value < 0 || value > 120000){
				throw new Exception ("InValid Year");	
		  }
		  _salary=value;
		 }
	}
	private int _joinyear;
	public int JoinYear{
			 get {
			return _joinyear;
		 }
		 set{
			if( (value - Age )< 21){
				throw new Exception ("InValid join year");	
		}
		_joinyear=value;
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

 public void PrintAll()
 {
 for(int i=0;i<=_index;i++){
 People[i].Print();
 }
 }}
public class nada{
	public static void Main()
	{
		var database= new Database();
    		Console.WriteLine("Name: ");
		var name= Console.ReadLine();
    		Console.WriteLine("Age: ");
		var age= Convert.ToInt32(Console.ReadLine());
    		Console.WriteLine("Year: ");
		var year= Convert.ToInt32(Console.ReadLine());
    		Console.WriteLine("Gpa: ");
		var gpa= Convert.ToSingle(Console.ReadLine());
		
		var student=new Student(name,age,year,gpa);
		database.AddStudent(student);
		
		////staff
    		Console.WriteLine("Salary: ");
		double salary= Convert.ToDouble(Console.ReadLine());
    		Console.WriteLine("JoinYear: ");
		int joinyear= Convert.ToInt32(Console.ReadLine());
		
	     var staff=new Staff(name,age,salary,joinyear);
		database.AddStaff(staff);
		
		
		while(true){
			Console.WriteLine("option: ");
			var option=Convert.ToInt32(Console.ReadLine());
			switch(option){
				case 1:
					Console.WriteLine("Name: ");
					var name1=Console.ReadLine();
					Console.WriteLine("Age: ");
					var age1=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Year: ");
					var year1= Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Gpa: ");
					var gpa1= Convert.ToSingle(Console.ReadLine());
					 try{
					var student1=new Student(name1,age1,year1,gpa1);
		                          database.AddStudent(student1);
					 }
					 catch(Exception e)
					 {Console.WriteLine(e.Message);
					 }
					break;
				case 2:	
				    Console.WriteLine("Name: ");
					var name2=Console.ReadLine();
					Console.WriteLine("Age: ");
					var age2=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Salary: ");
					var salary2= Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("JoinYear: ");
					var joinyear2= Convert.ToInt32(Console.ReadLine());
			         try{
					var staff2=new Staff(name2,age2,salary2,joinyear2);
		                        database.AddStaff(staff2);
					 }
					 catch(Exception e)
					 {Console.WriteLine(e.Message);
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
					 {Console.WriteLine(e.Message);
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
