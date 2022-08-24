using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrichniIgri
{
    internal class Registaciq
    {
        string nickname = "n";
        string passlord = "p";
        public void Registration()
        {
            Dictionary<string, string>acc  =new Dictionary<string, string>();
            

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                nickname = Console.ReadLine();
                passlord = Console.ReadLine();  
                acc.Add(nickname,passlord);


            }



            string s = Console.ReadLine();
            nickname = s;
            Console.WriteLine("To wich nickname you need pass");
            if (nickname==s)
            {
                Console.WriteLine("To "+nickname+"Pass is   " + acc[nickname]);
            }
            else if(nickname!=s)
            {
                Console.WriteLine(" Wrong Nickname ");

            }
            



        }








    }
}
