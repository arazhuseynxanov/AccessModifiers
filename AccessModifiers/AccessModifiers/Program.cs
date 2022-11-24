using ClassLibrary;

namespace AccessModifiers;
class Program
{
    static void Main(string[] args)
    {
        Department department = new Department("Araz", 20, 500);

        Employee employee = new Employee("Mahmud", "Hasanov", 430);

        Employee employee1 = new Employee("Araz", "Huseynxanov", 300);

        Employee employee2 = new Employee("Tural", "Hasanov", 290);

         department.AddEmployee(employee);
         department.AddEmployee(employee1);
         department.AddEmployee(employee2);

        


    }
    
}

