using System;
using System.Collections.Generic;
class person
{
    public int ID
    {
        get;
        set;
    }
      public string? name
      {
        get;
        set;
    }
    

    public override bool Equals (object obj){
        person p = obj as person;
        return p !=  null && p.ID == ID && p.name == name;

    }

    public override int GetHashCode()
    {
        return ID.GetHashCode() ^ name.GetHashCode();
    }
}
class StudentDetail
{

HashSet<person> list=new HashSet<person>();
    public void getDetail(){
person obj=new person();
obj.ID=1;
obj.name="sandy";

person obj1=new person();
obj1.ID=1;
obj1.name="sandy";

list.Add(obj);
list.Add(obj1);
Console.WriteLine(list);
foreach(var e in list){
    Console.WriteLine(e.ID+" "+e.name);
}

    }
}

class Detail
{
 
 
    public static void Main(){
   StudentDetail es=new StudentDetail();
   es.getDetail();
       
        
    }
}