using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROT13
{
    internal class Program
    {
        static char[] Alph = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text :");
            string txt = Console.ReadLine();

            string Answer = "";
            for (int i = 0; i < txt.Length; i++)
            {
                int index = FindIndex(Convert.ToChar(txt.Substring(i, 1)));


                if (index == -1)
                {
                    Answer += txt.Substring(i, 1);
                }
                else if (index < 13)
                {
                    Answer += Alph[index + 13];
                }
                else if (index > 12)
                {
                    Answer += Alph[index - 13];
                }

            }
            Console.WriteLine(Answer);
            Console.ReadKey();

        }

        private static int FindIndex(char ch)
        {
            int Index = 0;
            for (int i = 0; i < 26; i++)
            {
                if (Alph[i] == ch)
                    return Index;

                Index++;
            }

            //we use -1 as an error code
            return -1;
        }
    }
}
