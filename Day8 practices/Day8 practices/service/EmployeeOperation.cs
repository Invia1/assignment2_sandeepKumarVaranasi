using System;
using System.Collections.Generic;
using Day8_practices.Models;
using System.Linq;
namespace Day8_practices.service
{
    internal class EmployeeOperation
    {
        List<Employee> employees=new List<Employee>();
        public int  AddEmployee(Employee emp) {
          employees.Add(emp);
            
            return employees.Count;
        }
        public List<Employee> UpdateEmployee() { 
            return employees;
        }
        public int deleteEmployee(int id)
        {
            foreach (var obj in employees)
            {
                if (obj.EId == id)
                {
                    employees.Remove(obj);
                    break;
                }
            }
            return employees.Count;
        }
        public int updateEmployee(string name, string updatename)
        {
            foreach (Employee obj in employees)
            {
                if (obj.Ename == name)
                {
                    obj.Ename = updatename;
                }
            }
            return -1;
        }
        public void searchEmployee(int id)
        {
            foreach (Employee obj in employees)
            {
                if (obj.EId == id)
                {
                    Console.WriteLine(obj.Ename);
                    break;
                }
                else
                {
                    Console.WriteLine("Detail not found!");
                }
            }
            
        }
    }
}
