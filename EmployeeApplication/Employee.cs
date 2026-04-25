using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal class Employee
    {
        private string employeeID;
        private string firstName;
        private string lastName;
        private string position;


        public string EmployeeID { get { return employeeID; } set { employeeID = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Position { get { return position; } set { position = value; } }


        public Employee()
        {
            this.employeeID = "";
            this.firstName = "";
            this.lastName = "";
            this.position = "";
        }


        public Employee(string employeeID, string firstName, string lastName, string position)
        {
            this.employeeID = employeeID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }
    }
}

    

