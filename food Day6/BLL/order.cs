using food_Day6.Models;
using System;


namespace food_Day6.BLL
{
     class order
    {
        public food customerOrder()
        {

            food obj = new food();
            obj.FName = Console.ReadLine();
            obj.orderNumber = int.Parse(Console.ReadLine());
            return obj;
        }
    }
}
