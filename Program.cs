/*NAME: Cillian McMeekin
 * TITLE: CA4
 * SN : S00212739
 * DATE : 17/12/2020
 * 
 * 
 * 
 * ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA4
{
    class Program
    {
        static int[] townSales = new int[5];
        static string[] townNames = new string [5];
        static void Main(string[] args)
        {
            // declaring variables in array format 
            townNames[0] = "Sligo";
            townNames[1] = "Dublin";
            townNames[2] = "Letterkenny";
            townNames[3] = "Tralee";
            townNames[4] = "Cork";

            GetSalesNumbers();     // using method from below

            PrintReport();           // calling to main method 
        }
        static private void GetSalesNumbers() // Method to  get sales numbers 
        {
            for(int i = 0; i < 5;i++)
            {
                Console.Write("Enter sales for {0} : ",townNames [i]);
                townSales[i] = int.Parse(Console.ReadLine());

            }
        }
        static private int GetMostSales()
        {
            int mostSales = townSales[0];            // method to get the town name with most sales 
            int highestPosition = 0;
            for(int i = 1; i < townSales.Length; i++)     // .length = 5
            {
                mostSales = townSales[i];
                highestPosition = i;
            }
            return highestPosition;
        }
        static private int LessThanThousand()
        {
            int myResult = 0;
            for(int i = 0; i < townSales.Length;i++)
            {
                if(townSales[i] < 1000)                      // method to get sales less than 1000
                {
                    myResult++;
                }
            }
            return myResult;              // myResult returns an int 
        }
        static private int MoreThanFiveThousand()
        {
            int myResult = 0;
            for (int i = 0; i < townSales.Length; i++)               // method to get sales more than 500
            {
                if(townSales [i] > 5000)
                {
                    myResult++;                      // returns an int
                }
                
            }
            return myResult;
        }
        static private int BetweenTwoThousandAndFiveThousand()
        {
            int myResult = 0;
            for(int i = 0; i < townSales.Length; i++)                
            {
                if (townSales[i] >= 2000 && townSales[i] <= 5000)             // use of if statement to return beween 2 and 5 thousand 
                {
                    myResult++;
                }
            }
            return myResult;
        }
        static private void PrintReport()           // method to print report 
        {
            int totalSales = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\t\t Sales Report");
            Console.WriteLine("{0,-20}{1,-20}", "location", "Sales");

            for (int i = 0; i < townSales.Length;i++)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;     // accumalate sales for total
                totalSales += townSales[i];
                Console.WriteLine("{0,-20}{1,-20}",townNames[i],townSales [i]);             
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Total sales is {0}", totalSales );
            int mostSales = GetMostSales();
            Console.WriteLine("Town with most sales is {0}",townNames[mostSales] );

          
            Console.WriteLine("Number with Sales less than 1000 are {0}", LessThanThousand ());

            Console.WriteLine("Number with Sales more than five thousand are {0}", MoreThanFiveThousand ());

            Console.WriteLine("Number of towns between two and five thousand are {0}", BetweenTwoThousandAndFiveThousand ());

            double averageSales = totalSales / 5;         // sum to get averaage sales 
              
            Console.WriteLine("Average sales : {0}", averageSales );
        }
        
        
       
    }
}
