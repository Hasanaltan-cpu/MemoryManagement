using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement_Fields
{
   public class StringvsStringBuilder
    {
        /*String is immutable in C# that would mean you couldn’t modify it after it is created. It creates a new object of string type in memory if you will perform any operation.*/

        string str1 = "Welcome!";
        // creates a new string instance
        str1 += "Hello";
       

         /*This means that if an operation is performed on the string, it will not create a new instance every time. With that, it will not create new space in memory, unlike Strings.*/

         StringBuilder str1 = new StringBuilder("");
         str1.Append("Welcome!");
         str1.Append("Hello World!");
         string str2 = str1.ToString();

    }
}
