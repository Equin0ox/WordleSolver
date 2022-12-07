using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleHelper
{
    internal class WordleClass
    {
        public void Run()
        {
            string[] a = File.ReadAllLines("./morewords.txt");
            for (int loop = 0; loop < 9999; loop++)
            {
                List<string> c = a.ToList<string>();
                Console.WriteLine("jake pismeno je sede");
                char[] e = Console.ReadLine().ToCharArray();
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
                Console.WriteLine("jake pismeno je zlute a na jake pozici");
                string[] b = Console.ReadLine().Split(';');
                if (b[0]!="")
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        char[] f = b[j].ToCharArray();
                        for (int i = 0; i < c.Count; i++)
                        {
                            if (c[i].Contains(f[0]))
                            {
                                char[] g = c[i].ToCharArray();
                                if (f[0] == g[int.Parse(f[1].ToString()) - 1])
                                {
                                    c.RemoveAt(i);
                                    i--;
                                }
                            }
                            else
                            {
                                c.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }
                for (int i = 0; i < c.Count; i++)
                {
                    Console.WriteLine(c[i]);
                }
                Console.WriteLine("jake pismeno je zelene a na jake pozici");
                b = Console.ReadLine().Split(';');
                if (b[0]!="")
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        char[] f = b[j].ToCharArray();
                        for (int i = 0; i < c.Count; i++)
                        {
                            if (c[i].Contains(f[0]))
                            {
                                char[] g = c[i].ToCharArray();
                                if (f[0] != g[int.Parse(f[1].ToString()) - 1])
                                {
                                    c.RemoveAt(i);
                                    i--;
                                }
                            }
                            else
                            {
                                c.RemoveAt(i);
                                i--;
                            }
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
}