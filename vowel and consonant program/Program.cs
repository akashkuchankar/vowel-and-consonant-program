using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowel_and_consonant_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any alphabet");
            char ak = Convert.ToChar(Console.ReadLine());
            switch(ak)
            {
                case 'a':
                        Console.WriteLine("alphabet is vowel");
                    break;  
                    case 'e':
                    Console.WriteLine("alphabet is vowel");
                    break ;
                    case 'i':
                    Console.WriteLine("alphabet is vowel");
                    break;
                    case'o':
                    Console.WriteLine("alphabet is vowel");
                    break;
                    default:
                    Console.WriteLine("alphabet is consonant");
                    break;
                    Console.ReadLine();
            }

        }
    }
}
