using System;

namespace _27._03._22.task4
{
    internal class Program
    {

        //Verilmiş string dəyərin içərisində 2 söz olmasını və hər bir sözün böyük hərflə başlamasını yoxlayan metod
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            Console.WriteLine(findsentence(sentence));
        }
        public static bool findsentence(string sentence)
        {
            bool Check = false;
            bool bigFirstsentence = false;
            bool bigSecondsentence = false;
            string[] strArr = sentence.Split();
            if (strArr.Length == 2)
            {
                string Firstsentence = strArr[0];
                string Secondsentence = strArr[1];
                if (Firstsentence[0] == char.ToUpper(Firstsentence[0]))
                {
                    bigFirstsentence = true;

                }
                if (Secondsentence[0] == char.ToUpper(Secondsentence[0]))
                {
                    bigSecondsentence = true;

                }



            }
            Check = bigSecondsentence && bigFirstsentence;
            return Check;
        }
    }
}
