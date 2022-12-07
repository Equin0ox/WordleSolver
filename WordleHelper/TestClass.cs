using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleHelper
{
    internal class TestClass
    {
        public void Run()
        {
            string b = "abcdefghijklmn";
            char[] e =b.ToCharArray();
            string[] a = File.ReadAllLines("./words.txt");
            List<string> c = a.ToList<string>();
           
            
                for (int j = 0; j < e.Length; j++)
                {
                    for (int i = 0; i < c.Count; i++)
                    {
                        if (c[i].Contains(e[j]))
                        {
                            c.RemoveAt(i);
                            i--;
                        }
                    }
                }
                for (int i = 0; i < c.Count; i++)
                {
                    Console.WriteLine(c[i]);
                }
            
        }
    }
}