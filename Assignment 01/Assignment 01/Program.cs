using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program
    {
        class getUserInput
        {
            int noOfSiblings;
            //object of class DateTime to store DOB of siblings
            DateTime dateOfBirthObj = new DateTime();
            DateTime Obj1 = new DateTime();
            DateTime[] ary;


            //functions

            public void getInput()
            {
                Console.WriteLine("How many siblings ? ");
                noOfSiblings = Console.Read();
                ary = new DateTime[noOfSiblings];
                

                //string aa = "3";
                //int x = int.Parse(aa);
                //Console.WriteLine(aa.Length);
                string db;
                for (int i = 1; i <= noOfSiblings; i++)
                {
                    Console.WriteLine("Enter date of birth of sbling number" + i);
                    db = Console.ReadLine();
                    dateOfBirthObj = Convert.ToDateTime(db);
                    ary[i] = dateOfBirthObj;
                   // ageCalculation();

                }  //END OF FOR LOOP 
            
            }//END OF getInput()

            public void ageCalculation()
            {
                Obj1 = DateTime.Today;
                for (int j = 0; j < noOfSiblings; j++)
                {
                    TimeSpan periodCalObj = Obj1 -ary[j] ;
                    int totalDays = periodCalObj.Days;
                    int years = totalDays / 365;
                    int remainingDays = totalDays % 365;

                    int months = remainingDays / 30;
                    int days = remainingDays % 30;
                    Console.WriteLine("Age of current sibling is :" + years + " " + months + " " + days);
                }






               // float remainingDays = (days % 365);
               // int months = ((int) remainingDays)/30;
               // int days = 


               // days%365
            }

        } //end of class

        static void Main()
        {
            getUserInput obj = new getUserInput();
            obj.getInput();
            obj.ageCalculation();
            Console.ReadKey();
        }
    }
}
