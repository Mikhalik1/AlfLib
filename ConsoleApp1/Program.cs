using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] sim = "ынлззьгечыяазеьбъчйюсндбц".Replace(" ","").ToUpper().ToCharArray();
            
            string key = "мышь".ToUpper();
            int b = 0;
            string words = "";
            int count = 0;
            string result = "";
            string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            int[] index = new int[key.Length];
            List<string> text = new List<string>();

            for (int i = 0; i < sim.Length;i++)
            {
                if (count <= key.Length-1)
                {
                    words += sim[i];
                    count++;
                }
                else
                {
                    text.Add(words);
                    words = "";
                    count = 0;
                    i--;
                }
            }
            for(int i = 0;i < key.Length;i++)
            {
                words += " ";
            }
            
            text.Add(words);
            for (int j = 0; j < key.Length; j++)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (key[j] == alphabet[i])
                    {
                        index[j] = i;
                    }
                }
            }


            foreach (string s in text)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    for (int i = 0; i < alphabet.Length; i++)
                    {
                        if (b == 0)
                        {
                            if (s[j] == alphabet[i])
                            {
                                if (i - index[j] >= 0)
                                {
                                    result += alphabet[i - index[j]];
                                    b++;
                                }
                                else
                                {
                                    int c = index[j] - i;
                                    result += alphabet[33 - c];
                                    b++;
                                }

                            }
                        }

                    }
                    b = 0;
                }
            }
                
 




            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
