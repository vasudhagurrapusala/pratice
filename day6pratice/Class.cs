using System;
namespace consoleApplication
{

class Adhar
{
    public String Adharno{get;set;}
    public String Name{get;set;}
    public String dateofbirth{get;set;}
    public String Address{get;set;}

}

 class details

    

 {
    static void Main(String[] args)
    {
        Adhar va = new Adhar();

        va.Adharno="630676814575";
        va.Name="vasudha";
        va.dateofbirth="08-08-2000";
        va.Address="Markapur";
       
        Console.WriteLine(va.Adharno+" "+va.Name +" "+ va.dateofbirth+" "+ va.Address+" ");
       
    } 

 }
}