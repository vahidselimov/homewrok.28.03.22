using System;

namespace _27._03._22.task1
{
    internal class Program
    {
        //task1:Verilmiş string variable-ın dəyərini içərisində hər söz arasında bir boşluq gələcək vəzyətə salan metod.
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();




            string[] arr = sentence.Split(new char[] { ' ' });


            foreach (var item in arr)
            {
                Console.WriteLine(item);




            }


            string sentence2 = string.Join(' ', arr);



            Console.WriteLine(sentence2);
        }
    }
}
