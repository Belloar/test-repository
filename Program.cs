using System;
using System.Collections.Generic;
using System.Text;

namespace collections
{
    
     
    class Program
    {
        static void BraceCheck(string braces)
        {
         
           var bracesCheck = new Stack<char>();

           foreach(var i in braces)
           {
               if(i =='{')
               {
                   bracesCheck.Push(i);
               }
               else if(i =='}' && bracesCheck.Count != 0 )
               {
                   bracesCheck.Pop();
               }
                else if (i == '}' && bracesCheck.Count == 0 )
                {
                    Console.WriteLine("false");
                    return;
                }
           }
           if(bracesCheck.Count != 0 )
           {
               Console.WriteLine("false");
           }
           else
           {
               Console.WriteLine("true");
           }
          
        }
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            List<int> numbers = new List<int>() {1,2,3,4,5};
            nums.Add(50);
            nums.Add(67);
            Console.WriteLine(string.Join(" ", nums));
            nums.AddRange(numbers);
            Console.WriteLine(string.Join(" " ,nums));

         
            /*
            foreach(var letter in str)
            {
                if(chars.ContainsKey(letter))
                {
                    chars[letter] += 1 ;
                }
                else
                {
                    chars.Add(letter,1);
                }
            }

            foreach(var dic in chars)
            {
                Console.WriteLine($"{dic.Key} , {dic.Value}");
            }*/
            /*
            //Question1
            int[] number = new int[5] {1,1,2,3,1};
            Dictionary<int,int> dic = new Dictionary<int,int>();
            foreach(var element in number)
            {
                if(!dic.ContainsKey(element))
                {
                    dic.Add(element,1);
                }
            }
            foreach(var num in dic)
            {
                Console.Write(num.Key + " ");
            }*/
          

            BraceCheck("{{{{}}}}");




        }         
    }
}
