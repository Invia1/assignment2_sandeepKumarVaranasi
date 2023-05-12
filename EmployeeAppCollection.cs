// // using System;
// // using System.Collections;

// // class dataEntry{
// //  ArrayList objc=new ArrayList();
// //     public void AddData(){
// // objc.Add("sandeep");
// // objc.Add("prasant");
// // objc.Add("shubham");
// // foreach(var ch in objc){
// //  Console.WriteLine(ch);

// //     }


// //     }
   
// //     public static void Main(){

// // dataEntry obj =new dataEntry();
// // obj.AddData();
   
// //     }
// // }

// /******************************************************************************

//                             Online C# Compiler.
//                 Code, Compile, Run and Debug C# program online.
// Write your code in this editor and press "Run" button to execute it.

// *******************************************************************************/

using System;
using System.Collections;
class HelloWorld {
     ArrayList arr=new ArrayList()
     {
"shubham",23,"prasanst"
     };
     
   public void Addx(){
  arr.Add("sandy");
  arr.Add(212);
  arr.Add("sdjhk");
//    foreach(var ele in arr){
//        Console.WriteLine(ele);
//    }
   }
   public void removed(){
       arr.Remove("sandy");
     foreach(var e in arr){
          Console.WriteLine(e);
     }
   }
   public void update(){
       arr.Insert(0,"uedg");
     foreach(var e in arr){
          Console.WriteLine(e);
     }
   }
  public static void Main() {
    HelloWorld obj=new HelloWorld();
    // obj.Addx();
    // obj.removed();
    // obj.update();
    int n=int.Parse(Console.ReadLine());
    switch(n){
        case 1:
            obj.Addx();
            break;
        case 2:
            obj.removed();
            break;
        case 3:
             obj.update();
             break;
    }
  }
}

























