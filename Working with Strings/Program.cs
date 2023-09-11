using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skies are blue \n roses are red \n I love You");
            Console.WriteLine("Hi my name is \"khathutshelo\"");

            string FirstName = "Khathutshelo";
            string LastName = "Khavhatondwi";

            Console.WriteLine(FirstName + " " + LastName );

            Console.WriteLine("The length of the fName" +  FirstName.Length);

            Console.WriteLine(FirstName.ToLower());
            Console.WriteLine(LastName.ToUpper());
            Console.WriteLine("Does firstName include " + FirstName.Contains("K"));
            Console.WriteLine("The first leter of Fname is " + FirstName[0]);
            Console.WriteLine(FirstName.IndexOf("h"));
            Console.WriteLine("SubString From 1 " + FirstName.Substring(2,5));


            Console.ReadLine();
        }
    }
}
