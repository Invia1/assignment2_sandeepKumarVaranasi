using System;
using Day8_practices.Models;
using Day8_practices.service;

namespace Day8_practices.UI
{
    internal class MainFunction
    {

        public static void Main(string[] args)
        {
            Employee obj= new Employee();
            Console.WriteLine("Enter Employee Id :");
            obj.EId = 12; //int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name :");
            obj.Ename = "sandy";//Console.ReadLine();
            Console.WriteLine("Enter Employee Age :");
            obj.Age = 23;//int.Parse(Console.ReadLine());
            Employee obj1=new Employee();
            Console.WriteLine("Enter Employee Id :");
            obj1.EId = 62; //int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name :");
            obj1.Ename = "mandy";//Console.ReadLine();
            Console.WriteLine("Enter Employee Age :");
            obj1.Age = 23;//int.Parse(Console.ReadLine());

            EmployeeOperation op = new EmployeeOperation();
            op.AddEmployee(obj);
            op.AddEmployee(obj1);
            
            //Console.WriteLine(op.AddEmployee(obj));

            List<Employee> list =op.UpdateEmployee();
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.EId+" " +emp.Ename+ " " +emp.Age);
            }
            
            op.deleteEmployee(obj1.EId);
            foreach (var ele in list)
            {
                Console.WriteLine(ele.EId + " " + ele.Ename + " " + ele.Age);
            }
            op.updateEmployee(obj.Ename, "prasant");
            foreach (var ele in list)
            {
                Console.WriteLine(ele.EId + " " + ele.Ename + " " + ele.Age);
            }
            op.searchEmployee(obj.EId);
            foreach (var ele in list)
            {
                Console.WriteLine(ele.EId + " " + ele.Ename + " " + ele.Age);
            }

        }
    }
}
