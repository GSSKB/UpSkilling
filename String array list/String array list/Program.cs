using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_array_list
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[4];

            Console.WriteLine("Please enter your input");

            for (int i = 0; i < 4; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("The input you entered---");
            for (int i = 0;i< arr.Length; i++){

                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
