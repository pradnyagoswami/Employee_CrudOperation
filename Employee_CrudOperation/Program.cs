using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_CrudOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            EmployeeCrud crud=new EmployeeCrud();
            do
            {
                Console.WriteLine("1.Enter Employee List");
                Console.WriteLine("2.Get Employee by ID");
                Console.WriteLine("3.Add Eployee");
                Console.WriteLine("4.Update Employee Details");
                Console.WriteLine("5.Delete Employee Details");

                Console.WriteLine("Select option");
                int option=Convert.ToInt32(Console.ReadLine());

                switch(option) 
                {

                    case 1:
                        List<Employee> list = crud.GetEmployee();
                        Console.WriteLine("Eid,Name,Salary\t,Cname");
                        foreach (Employee employee in list)
                        {

                            Console.WriteLine($"{employee.eid},{employee.Name},{employee.Salary},{employee.cname}");


                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Employee ID");
                        int id=Convert.ToInt32(Console.ReadLine());
                        Employee e = crud.GepEmployeeByID(id);
                        Console.WriteLine("Eid,Name,Salary\t,Cname");
                        Console.WriteLine($"{e.eid},{e.Name},{e.Salary},{e.cname}");
                        break;
                        case 3:
                        Employee e1 = new Employee();
                        Console.WriteLine("Enter Employee id");
                        e1.eid=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        e1.Name=Console.ReadLine();
                        Console.WriteLine("Enter employee salary");
                        e1.Salary=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee company name");
                        e1.cname=Console.ReadLine();
                        crud.AddEmployee(e1);
                        Console.WriteLine("Employee details saved..");
                        break;
                        case 4:
                        Employee e2 = new Employee();
                        Console.WriteLine("Enter Employee id you want to update");
                        e2.eid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        e2.Name = Console.ReadLine();
                        Console.WriteLine("Enter employee salary");
                        e2.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee company name");
                        e2.cname = Console.ReadLine();
                        crud.UpdateEmployee(e2);
                        Console.WriteLine("Employee details updated..");
                        break;
                    case 5:
                        Console.WriteLine("Enter Employee Id you want to delete");
                        int id2=Convert.ToInt32(Console.ReadLine());
                        crud.DeleteEmployee(id2);
                        Console.WriteLine($"{id2} deleted");
                        break;


                }
                Console.WriteLine("Press 1 for Continue");
                no=Convert.ToInt32(Console.ReadLine());





            }
            while (no == 1);








        }
    }
}
