using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Marks;
                Console.WriteLine("Enter the Marks in pre");
                Marks = int.Parse(Console.ReadLine());
                if (Marks > 60)
                {
                    Console.WriteLine("Enter the Marks in final");
                    int Finalmarks = int.Parse(Console.ReadLine());
                    var result = Finalmarks > 55 ? "Selected" : "Fail in Final";
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Fail in pre");
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("End of the code");
                Console.ReadKey();
            }
            

        }
    }
}
