using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement_Fields
{
    public class Student
    {
        int number = 15;                 //
        string name = "Hasan";           // => All of them now occured on the Stack Part and u can not manage this.
        double height = 1.83;            //

    


    }

     Student student = new Student(); /// =>  Objects which are created by New  occure Heap Part.
        student.name="Hasan";

                                      //Reference is student1 => Stack
                                      //Value is Hasan => Heap



      if (true)
    {    
        Student student2 = new Student();
     }

                                        //When if blocks over, object 's reference will be "0" at that moment 
                                        //Garbage collector works and Heap will be clear.




