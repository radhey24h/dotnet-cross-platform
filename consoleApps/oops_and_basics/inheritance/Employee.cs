namespace oops_and_basics
{
    public class Employee
    {
        public int _id;
        private string _name;
        private string _address;
        public Employee()
        { 
            
        }
        public Employee(string name)
        {
            this._name = name;
        }
        public string Name   // property
        {
            get { return _name; }   // get method
            set { _name = value; }  // set method
        }
        public string Address
        {
            get { return _address; }   // get method
            set { _address = value; }
        }

        public string AddName(string firstName)
        {
            //Person person = new Person(1, "");
            return new Employee()._name = firstName;
        }

    }
}