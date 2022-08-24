using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MatrichniIgri
{
    internal class labirint
    {
        bool end = true;
        int stepst=0;   
        int row = 0;
        int col = 0;
        public string[,] matrix ={ {"k","0","#","#", "#","#","#" },
                                   {"#","0","0","0", "0","#","#" },
                                   {"#","#","#","#", "0","#","#" },
                                   {"#","#","#","#", "0","0","0" },
                                   {"#","#","#","#", "#","#","k" }
        };
        string s = "start";
        public void Finish()
        {
            Console.Clear();
            Console.WriteLine("    You passs the Labirin write /start/ to play again     ");
            string menu = Console.ReadLine();
            if (menu=="start")
            {
               

            }

        }
        public void Bourd()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[row, col] = matrix[i, j];
                }
            }
           

            while (true)
            {
                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    for (int c = 0; c < matrix.GetLength(1); c++)
                    {
                        Console.Write(matrix[r, c]);
                    }
                    Console.WriteLine();
                }

                matrix[row, col] = "k";
                string move = Console.ReadLine();
                Console.Clear();
                if (move == "d"&&matrix[row,col+1]=="0")
                {
                    col++;
                    matrix[row,col] = "k";
                    if (col - 1 >= 0)
                    {
                        matrix[row, col - 1] = "0"
            ;
                    }


                }
                if (move == "s"&&matrix[row+1,col]=="0")
                {
                    row++;
                    matrix[row, col] = "k";
                    if (row - 1 >= 0)
                    {
                        matrix[row - 1, col] = "0";
                    }

                }
                if (move == "a"&& matrix[row,col-1]=="0")
                {
                    col--;
                    matrix[row, col] = "k";
                    if (col + 1 > 0)
                    {
                        matrix[row, col + 1] = "0";

                    }

                }
                if (move == "w"&&matrix[row-1,col]=="0")
                {
                    row--;
                    matrix[row, col] = "k";
                    if (row + 1 > 0)
                    {
                        matrix[row + 1, col] = "0";
                    }

                }
                if (move=="s"&& matrix[row + 1, col] == "k")
                {
                    Finish();

                }
            }




        }
        public void Finpath()
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    
                    Console.Write(matrix[r,c]);
                    matrix[row,col]=matrix[r,c];
                }
                Console.WriteLine();

            }
            
            
            if (s == "start")
            {
                Console.Clear();
                while (end)
                {
                    for (int r = 0; r < matrix.GetLength(0); r++)
                    {
                        for (int c = 0; c < matrix.GetLength(1); c++)
                        {

                            Console.Write(matrix[r, c]);
                            Thread.Sleep(500);
                        }
                        Console.WriteLine();

                    }
                    matrix[row, col] = "k";
                    if (matrix[row, col + 1] == "0")
                    {
                        stepst++;
                        col++;
                        matrix[row, col] = "k";
                        Console.Clear();
                        if (col - 1 >= 0)
                        {
                            matrix[row, col - 1] = "1";
                
                        }
                    }
                    if (matrix[row + 1, col] == "0")
                    {
                        stepst++;
                        row++;
                        matrix[row, col] = "k";
                        Console.Clear();
                        if (row - 1 >= 0)
                        {
                            matrix[row - 1, col] = "1";
                        }

                    }
                    if (matrix[row, col - 1] == "0")
                    {
                        stepst++;
                        col--;
                        matrix[row, col] = "k";
                        Console.Clear();
                        if (col + 1 > 0)
                        {
                            matrix[row, col + 1] = "1";

                        }

                    }
                    if (matrix[row - 1, col] == "0")
                    {
                        stepst++;
                        row--;
                        matrix[row, col] = "k";
                        Console.Clear();
                        if (row + 1 > 0)
                        {
                            matrix[row + 1, col] = "1";
                        }

                    }
                    if (matrix[row + 1, col] == "k")
                    {
                        stepst++;
                        end = false;
                        Console.WriteLine("STEPS ="+stepst+"to pass the labirint");
                        
                        break;
                        
                        
                    }









                }

            }








        }
        
    }
}
