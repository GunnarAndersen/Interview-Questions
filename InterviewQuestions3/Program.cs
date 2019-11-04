using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Reverse(string text)
            {
                if (text == null) return null;
                char[] array = text.ToCharArray();
                Array.Reverse(array);
                return new String(array);
            }
 
            Console.ReadLine();
        }


    }
}
