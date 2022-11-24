using System;
namespace ClassLibrary
{
	public class Department
	{
		private string _name;
		private int _employeeLimit;
		private int _salaryLimit;
        public Employee[] _employees;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int EmployeeLimit
        {
            get { return _employeeLimit;}
            set
            {
                if (value > 0)
                {
                    _employeeLimit = value;
                }
              
            }
            
        }
        public int SalaryLimit
        {
            get { return _salaryLimit; }
            set
            {
                if (value >250)
                {
                    _salaryLimit = value;
                }
            }
        }

        public Employee[] Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        public Department(string name,int employeeLimit,int salaryLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
            SalaryLimit = salaryLimit;
            Employees = new Employee[employeeLimit];

        }

        public void AddEmployee(Employee employees)
        {
            Employees.Append(employees);
            
        }

    }
}

