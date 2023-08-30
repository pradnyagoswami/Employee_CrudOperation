using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employee_CrudOperation
{
    public class Employee
    {
        public int eid { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string cname { get; set; }

    }
    public class EmployeeCrud
    {

        private List<Employee> employeelist;
        public EmployeeCrud()
        {

            employeelist = new List<Employee>()
            {
                new Employee{eid=501,Name="Pradnya",Salary=66000,cname="infosys"},
                new Employee{eid=502,Name="Sneha",Salary=45000,cname="wipro"}

            };

        }
        public List<Employee> GetEmployee()
        {
            return employeelist;
        
        
        }
        public Employee GepEmployeeByID(int eid)
        { 
            Employee employee = new Employee();
            foreach (Employee e in employeelist) 
            {

                if (e.eid == eid)
                {

                    employee = e;
                    break;
                
                }
            
            }
            return employee;
        
        
        }
        public void AddEmployee(Employee e)
        { 
            employeelist.Add(e);

        
        }
        public void UpdateEmployee(Employee e)
        {
            foreach (Employee employee in employeelist)
            { 
                if(employee.eid == e.eid) 
                {
                   
                    employee.Name= e.Name;
                    employee.Salary = e.Salary;
                    employee.cname = e.cname;
                    break;
                
                }
           
            }
        }
        public void DeleteEmployee(int id) 
        {
            foreach (Employee employee in employeelist)
            { 
            if (employee.eid == id) 
                {
                
                employeelist.Remove(employee);
                    break;
                
                
                }
            
            }

        
        
        
        }
    
    
    
    
    
    
    
    
    
    
    }




}
