namespace SampleNamespace
{
    public class Customer : Person
    {
        //fields
        private  double cashOnHand;

        //constructors
        public Customer(double Cash) : base()
        {
            cashOnHand = Cash;
        }

        //set functions
        public void setCashOnHand(double Cash)
        {
            cashOnHand = Cash;
        }

        //get functions
        public void getCash()
        {
            Console.WriteLine($"{this.getFirstName()} has ${cashOnHand} on hand.");
        }
    }
}