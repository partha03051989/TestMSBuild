using System;

namespace TestMSBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            var showResults=Add(9, 10);
            Console.WriteLine("The Final Results from Addition is:"+showResults);

        }
        /// <summary>
        /// adding the and getting two different values as result 
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static int Add(int val1,int val2)
        {
            if (val1==0)
            {
                Console.WriteLine("Enter valid input in order to execute ");
            }
            int result = 0;
            return result = val1 + val2;s

        }
    }
}
