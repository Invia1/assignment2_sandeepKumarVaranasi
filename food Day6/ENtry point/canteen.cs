using food_Day6.BLL;
using food_Day6.Models;
using System;


namespace food_Day6.ENtry_point
{
    class canteen
    {
        public static void Main()
        {
            order EmpOrd = new order();
            food temp = EmpOrd.customerOrder();
            Console.WriteLine(temp.FName + " " + temp.orderNumber);
            
        }
    }
}