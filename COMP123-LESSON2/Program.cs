using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
*Author name: dhruti patel
*date: may17, 2016
*daate modified: may 17, 2016
*description : advance method demo for lesson 2
*version : 0.0.3 - Added addXandY method and associated unit test
*/

   
namespace COMP123_LESSON2
{
    /**
   *Main Private class for lesson 2
   *
   *@class program
   */
   public class Program
    {
        /**
        *Main Method for our driver class
        *
        *@constructor Main
        *@param {string[]} args
        */
       public static void Main(string[] args)
        {
            int x = 50;
            int y = 40;
            int result = 0;
            result = addXandY(x, y);
            Console.WriteLine(result);
        }
        /**
        *simple method to add two values
        *
        *@param addXandY
        *@
        */
        public static int addXandY(int firstnumber, int secondnumber)
        {
            int result = 0;
            result= firstnumber + secondnumber;
            return result;
        }
    }
}
