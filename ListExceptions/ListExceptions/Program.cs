using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                List<float> numerators = new List<float>() { 300, 49, 109, 563, 849, 234, 550, 495, 938, 840 };
                Console.WriteLine("Please give me a number to divide my numberators by");
                int denominator = Convert.ToInt32(Console.ReadLine());

                foreach (float numberator in numerators)
                {
                    float quotient = numberator / denominator;
                    Console.WriteLine(numberator + "/" + denominator + "=" + quotient);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("You have exited the division problems");
                Console.ReadLine();
            }

        }
    }
}
