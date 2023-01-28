namespace CSharpConventions.Model
{
    //Sequence
    /*
    Place constants at the top of the file
    After that place local variables
    After that place properties

    After that place the constructor

    Then the Methods & functions

    Use plural while naming collection variables
    */
    
    /*All class files must have the same name as as the class. 
Example, if you have a class named Employee, put it in a 
file called Employee.cs*/

    //Use a separate file for each class you declare

    //All class names must be in PascalCase. 

    public class Employee
    {
        //Interface names should start with an I. Usually they are in their own file
        public interface IEmployee
        {
            int GetEmployeeCount();
        }
        
        //All constants should be fully capitalized
        public const string COMPANY_NAME_MAIN = "My Company";

        //Name private local variables in camelCase with an underscore i.e. > _camelClase
        private int _employeeCount;
        public List<string> _employees; //All collections should have a name in plural

        //Public properties must be named in PascalCase
        public string EmployeeName { get; set; }

        public Employee()
        {
            //Constructor
        }

        //Functions must be in PascalCase, and should start with Get
        public string GetEmployeeCode()
        {
            //Local variables inside a function/method should be in camelCase
            string employeeCode = "CODE01";

            return employeeCode;
        }

        //Method names should be in PascalCase and should be named after what they do
        public void HireEmployee(string nameOfPerson) //Method/Function parameters must be named in camelCase
        {
            Console.Write(nameOfPerson);
            return;
        }

        //Functions that check for a condition should start with 'Is' and return Boolean
        public bool IsEmployeeWorking()
        {
            return true;
        }

    }
}
