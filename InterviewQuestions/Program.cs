using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class Method
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            List<int> myInts = new List<int>();
   
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] % 2) != 0)
                    myInts.Add(arr[i]);
                
            }
            int sum = myInts.Sum();

            Console.WriteLine(sum);
 
            Console.ReadLine();   
        }
    }
}
