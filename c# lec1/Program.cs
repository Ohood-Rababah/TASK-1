using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lec1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
           
            Program obj = new Program();

          string  result= obj. CapitalizeTitle(title);

            // 3. طباعة النتيجة
            Console.WriteLine($"Title :{result }");



        }
           public string CapitalizeTitle(string title)
        {
            string[] words = title.Split(' ');  

            for (int i = 0; i < words.Length; i++)  
            {
               

                if (words[i].Length > 2)
                {
                    words[i] = words[i][0].ToString().ToUpper() + words[i].Substring(1).ToLower();
                }
             
                else
                {
                    words[i] = words[i].ToLower();
                }
            }

            // نرجع الجملة بعد التعديل
            return string.Join(" ", words);  // هنا ندمج الكلمات مرة أخرى في جملة واحدة
        }


    }
}

