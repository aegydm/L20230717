using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230717
{
    internal class Program
    {

        //sum, avg 

        static void Calcualate(int a , int b, out int sum, out float avg)
        {
            sum = a + b;
            avg = (float)sum / 2.0f;
        }
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int sum = 0;
            float avg = 0;
            Calcualate(a, b, out sum, out avg);
            Console.WriteLine(sum + " & " + avg);

        }
    } 
}
