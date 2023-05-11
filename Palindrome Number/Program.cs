using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // X = 121;
            
            int []a = { 1, 2, 1 };
            int temp = 0;
            int temp2 = 0;
            for(int j =0;j<a.Length;j++)
            {
                temp2 = a[j];
            }
            for(int i =a.Length-1;i>=0;i--)
            {
                temp = a[i];
            }
            if(temp==temp2)
            {
                Console.WriteLine("This is palindrome number");
            }
            else
            {
                Console.WriteLine("This is not palindrome");
            }
            
            {

            }
        }
    }
}
