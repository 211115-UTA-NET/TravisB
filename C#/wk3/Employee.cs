using System;

namespace SampleNamespace
{
    public class Employee : Person
    {
        //Fields
        int hoursWorked;
        double payRate;

        //Constructor
        public Employee(int hoursWorked, double payRate, string setFirstName, string setLastName) : base()
        {
            this.hoursWorked = hoursWorked;
            this.payRate = payRate;
        }
        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {
            this.hoursWorked = 30;
            this.payRate = 20;
        }
        public Employee() : base()
        {
            this.hoursWorked = 30;
            this.payRate = 20;
        }

        public virtual void doWork()
        {
            Console.WriteLine($"I've worked {hoursWorked} hours.");
        }

        //get functions
        public void printName()
        {
            Console.WriteLine(this.getFirstName());
        }

        public int getHours()
        {
            return hoursWorked;
        }
        // public string printLast()
        // {
        //     return this.get;
        // }

        //set functions
        public void changeHours(int Hours)
        {
            this.hoursWorked = Hours;
        }

        public void changeWage(double Wage)
        {
            this.payRate = Wage;
        }

        public void changeWage()
        {
            this.payRate = Double.Parse(Console.ReadLine());
        }

        public void changeHours()
        {
            this.hoursWorked = int.Parse(Console.ReadLine());
        }
    }
}