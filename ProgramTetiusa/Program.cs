using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTetiusa
{
    class Program
    {
        //start point (osie są na odwrót x jest Y a y jest X)
        public static int x = 2;
        public static int y = 1;

        //TABLICA DANYCH
        public static int[,] array = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10,11,12},
                {13, 14,15,16}
            };
        //METODY RUCHU PO TABLICY
        public static void MoveRight()
        {
            Console.WriteLine(array[x, y] + " CURRENT");
            y++;
            Console.WriteLine(array[x, y] + " RIGHT");
        }
        public static void MoveLeft()
        {
            Console.WriteLine(array[x, y] + " CURRENT");
            y--;
            Console.WriteLine(array[x, y] + " LEFT");
        }
        public static void MoveUp()
        {
            Console.WriteLine(array[x, y] + " CURRENT");
            x--;
            Console.WriteLine(array[x, y] + " UP");
        }
        public static void MoveDown()
        {
            Console.WriteLine(array[x, y] + " CURRENT");
            x++;
            Console.WriteLine(array[x, y] + " DOWN");
        }

        //METODA ZAPISU ZMIANY WARTOSCI DLA DANEGO POLA
        public static void WriteMoveValue(int[,] array, int x, int y, int iterator)
        {
            array[x, y] = iterator;
            Console.WriteLine(array[y, x]);
        }
        
        static void Main(string[] args)
        {
            if (array.GetLength(0).Equals(array.GetLength(1)))
            {
                int REPEATS = 1;
                int nextMove = 1;

                for (int i = 1; i <= 16; i++)
                {
                    
                    //NA SZTYWNO RUCH W PRAWO
                    if (i.Equals(1))
                    {
                        MoveRight();       
                    }
                    //RESZTA PRACY
                    else
                    { 
                        switch (nextMove)
                        {
                            case 1:

                                for (int a = 0; a < REPEATS; a++)
                                {
                                    MoveUp(); 
                                }
                                nextMove = 2;
                                REPEATS = REPEATS + 1;
                               
                                break;

                            case 2:

                                for (int a = 0; a < REPEATS; a++)
                                {
                                    MoveLeft();
                                }
                                nextMove = 3;
                                break;

                            case 3:
                                for (int a = 0; a < REPEATS; a++) { 
                                    MoveDown();
                                }
                                nextMove = 4;
                                REPEATS = REPEATS + 1;
                                break;

                            case 4:
                                for (int a = 0; a < REPEATS; a++)
                                {
                                    MoveRight();
                                }
                                nextMove = 1;
                                break;
                        }
                    }
                    //WriteMoveValue(array, x, y, i);
                }
            }
            else
            {
                throw new Exception("TABLICA NIE MA TAKICH SAMYCH DLUGOSCI WIERSZY I KOLUMN!");
            }
            Console.ReadLine();
        }
    }
}
