using System;
using System.Text.RegularExpressions;
using System.IO;

namespace regular_expr
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 из конспекта
            Regex r = new Regex(@"\d{2}-\d{2}-\d{2}");
            string text = @"12-34-56 adasdsadfdj 12dfsf0 32-43-12f 76-56-34";
            string newText = "";
            string temp_str = "";

            MatchCollection matchCollection = r.Matches(text);
            foreach (Match match in matchCollection)
            {
                newText = match.ToString();
                temp_str = newText.Insert(2, "0");
                Console.WriteLine(Regex.Replace(newText, r.ToString(), temp_str));
            }



            //2 из конспекта
            /*Regex r = new Regex(@"tel[:]?|cat[:]?");
            string str = @"tel and score will go to cat with my cat of tel";

            string newStr = Regex.Replace(str, r.ToString(), "");
            Console.WriteLine(newStr);*/



            //3 из конспекта
            /*
             * дата
             * время
             * целое
             * дробь
             */

            /*Regex r = new Regex(@" (\d{2}\.\d{2}\.\d{2,4}) | (\d{2}(\.|\:)\d{2}) | ([-+]?\d+) | ([-+]?\d+[.,]\d*)");           
            string str = " 12.32.2005 произошел сбой на электростанции 12.33.05 сбой был устранен в 12:34 или в 32.54 " +
                        " В это время на улице было 5 или -10" +
                         " я могу сказать это с точностью до 1.56 или -9,54  ";

            string path = @"P:\test.txt";
            FileStream file = new FileStream(path,FileMode.OpenOrCreate,FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(file);

            MatchCollection matchCollection = r.Matches(str);
            foreach (Match match in matchCollection)
            {
                writer.Write(match.ToString());
            }

            writer.Close();*/



            //4 из конспекта
            /*Regex r = new Regex(@"(\d{1,2}/[a-z]+/\d{4}:(\d{2}:){2}\d{2} [+]\d{4})|((\d{1,3}\.){3}\d{1,3})", RegexOptions.IgnoreCase);
            Console.WriteLine(r.ToString());
            
            string path = @"P:\connects.log";
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file);
            string text = reader.ReadToEnd();
            Console.WriteLine(text);
            MatchCollection matchCollection = r.Matches(text);

            if (matchCollection.Count == 0)
                Console.WriteLine("null");

            foreach(Match match in matchCollection)
            {
                Console.WriteLine(match.ToString());
            }
            reader.Close();
            */



        }
    }
}
