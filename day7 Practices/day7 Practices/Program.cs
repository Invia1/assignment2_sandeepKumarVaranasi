using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

class personDetails
{
    ArrayList obj=new ArrayList();
    public void ENtry()
    {
        obj.Add("sandeep");///boxing because value type convert into reference type
        obj.Add(12000);//value type to refrence type is boxing
        int salary = Convert.ToInt32(obj[1]);//this is known as unboxing 
        string name = Convert.ToString(obj[0]);//reference to value type;
        Console.WriteLine(name + " " + salary);

       
    }
    public static void Main()
    {
        personDetails personDetail = new personDetails();
        personDetail.ENtry();
    }
}