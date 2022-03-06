using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using static System.Console;
namespace CSharp_Shell
{
	public enum Months
	{    
		Nome,
		January,
		February,
		March,
		April,
		May,
		June,
		July,
		August,
		September,
		October,
		November,
		December,
	}
    public static class Program 
    {
        public static void Main() 
        {
           WriteLine("Hello, write a number between 1 to 12\n");
           int number = int.Parse(ReadLine());
		   foreach (var item in Enum.GetValues(typeof(Months)))
           {
             if(number == Convert.ToInt32(item))
             { 
             	WriteLine(item);
             	
             }
             else if (number == 0)
             {
             	WriteLine("Invalid");
             	break;
             }
             else
             {
             	WriteLine("Invalid");
             	break;
             }
           }
           
           
        }
    }
}