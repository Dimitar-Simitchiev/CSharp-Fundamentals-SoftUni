using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrichniIgri
{
    internal class Morskishah
    {
        public string[,] duska ={ {"-","-","-" }, 
                         { "-", "-", "-" }, 
                         { "-", "-", "-" } };
        int row = 0;
        int col = 0;
        
        string player = "1";
        bool winer = false;
        bool end = true;

        public void Duska()
        {
            for (int i = 0; i < duska.GetLength(0); i++)
            {
                for (int j = 0; j < duska.GetLength(1); j++)
                {
                    duska[row, col] = duska[i, j];

                }

            }


        }
        public void  Winner()
        {
            if (((duska[0, 0] == duska[0, 1] && duska[0, 0] == duska[0, 2]))&&((duska[0,0]!="-")))
            {
                winer = true;
                
            }
            if (((duska[1, 0] == duska[1, 1] && duska[0, 0] == duska[1, 0])) && ((duska[1, 0] != "-")))
            {
                winer = true;
                
            }
            if (((duska[2, 0] == duska[2, 1] && duska[2, 0] == duska[2, 2])) && ((duska[2, 0] != "-")))
            {
                winer = true;

            }
            if (((duska[0, 0] == duska[1, 0] && duska[0, 0] == duska[2, 0])) && ((duska[0, 0] != "-")))
            {
                winer = true;

            }
            if (((duska[0, 1] == duska[1, 1] && duska[0, 1] == duska[2, 1])) && ((duska[0, 1] != "-")))
            {
                winer = true;

            }
            if (((duska[0, 2] == duska[1, 2] && duska[0, 2] == duska[2, 2])) && ((duska[0, 2] != "-")))
            {
                winer = true;


            }
            if (((duska[0, 0] == duska[1, 1] && duska[0, 0] == duska[2, 2])) && ((duska[0, 0] != "-")))
            {
                winer = true;

            }
            if (((duska[2, 0] == duska[1, 1] && duska[2, 0] == duska[0, 2])) && ((duska[2, 0] != "-")))
            {
                winer = true;

            }


        }
        public void Morskishahstart()
        {
            
           
            while (end)
            {
                Console.Clear();
                for (int r = 0; r < duska.GetLength(0); r++)
                {
                    for (int c = 0; c < duska.GetLength(1); c++)
                    {
                        Console.Write(duska[r, c]);
                    }
                    Console.WriteLine();
                }
                if (player=="1")
                {
                    Console.WriteLine("Playere 1 :");
                    row = int.Parse(Console.ReadLine());
                    col = int.Parse(Console.ReadLine());
                    if (((row>=0&&row<=2)&&(col>=0&&col<=2))&&duska[row,col]=="-")
                    {
                        
                        duska[row, col] = "o";
                        Winner();
                        if (winer==true)
                        {
                            Console.WriteLine("We have winner" + player);
                            end = false;
                            break;
                        }
                        
                        player= "2";    
                        Morskishahstart();

                    }
                    




                }
                if (player == "2")
                {
                    Console.WriteLine("Playere 2 :");
                    row = int.Parse(Console.ReadLine());
                    col = int.Parse(Console.ReadLine());
                    if (((row >= 0 && row <= 2) && (col >= 0 && col <= 2))&& duska[row, col] == "-")
                    {
                        duska[row, col] = "x";
                        Winner();
                        if (winer == true)
                        {
                            Console.WriteLine("We have winner" + player);
                            end = false;
                            break;
                        }
                        player = "1";
                        Morskishahstart();

                    }


                }
                





            }





        }



    }
}
