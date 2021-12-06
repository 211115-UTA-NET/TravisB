namespace SampleNamespace
{
    public class Trainer : Employee
    {
        //Fields
        private int classSize;
        private string specialty;

        //constructors
        public Trainer() : base("Richard", "Hawkins")
        {
            classSize = 22;
            specialty = "DevOps";
        }
        public Trainer(int classSize, string specialty, int HoursWorked, double payRate, string setFirstName, string setLastName) : base(HoursWorked, payRate, setFirstName, setLastName)
        {
            this.classSize = classSize;
            this.specialty = specialty;
        }
        //set functions
        public string Specialty
        {
            get { return specialty; }
            set { specialty=value; }
        }
        public void setSpecialty(string specialty)
        {
            this.specialty = specialty;
        }

        public override void doWork()
        {
            Console.WriteLine($"It's okay if you have not reached {this.getHours()} hours, it's only Wednesday.");
        }

        //get functions
        public int getClassSize()
        {
            Console.WriteLine($"{this.getFirstName}'s class has {classSize} students");
            return classSize;
        }
        public void getSpecialty()
        {
            Console.WriteLine($"{this.getFirstName()}'s specialty is {specialty}");
        }

        public int setClassSize
        {
            get {return classSize; }
            set {classSize = value;}
        }
    }
}