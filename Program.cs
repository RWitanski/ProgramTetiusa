// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ProgramTetiusa
{
    using System;

    /// <summary>
    ///     The program.
    /// </summary>
    internal class Program
    {
        // start point (osie są na odwrót x jest Y a y jest X)
        #region Static Fields

        /// <summary>
        ///     The array.
        /// </summary>
        private static readonly int[,] array = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

        /// <summary>
        /// The col lenght.
        /// </summary>
        private static readonly int colLenght = array.GetLength(1);

        /// <summary>
        /// The row lenght.
        /// </summary>
        private static readonly int rowLenght = array.GetLength(0);

        /// <summary>
        /// The total elements.
        /// </summary>
        private static readonly int totalElements = rowLenght * colLenght;

        /// <summary>
        ///     The iterator.
        /// </summary>
        private static int iterator = 1;

        /// <summary>
        ///     The x.
        /// </summary>
        private static int x = 2;

        /// <summary>
        ///     The y.
        /// </summary>
        private static int y = 1;

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The move down.
        /// </summary>
        public static void MoveDown()
        {
            Console.WriteLine(array[x, y] + " CURRENT");
            if (iterator < totalElements)
            {
                x++;
                iterator++;
            }

            WriteMoveValue(array, x, y, iterator);
            Console.WriteLine(array[x, y] + " DOWN");
        }


        /// <summary>
        ///     The move left.
        /// </summary>
        public static void MoveLeft()
        {
            Console.WriteLine(array[x, y] + " CURRENT");
            if (iterator < totalElements)
            {
                y--;
                iterator++;
            }

            WriteMoveValue(array, x, y, iterator);
            Console.WriteLine(array[x, y] + " LEFT");
        }

        /// <summary>
        ///     The move right.
        /// </summary>
        public static void MoveRight()
        {
            Console.WriteLine(array[x, y] + " CURRENT");
            if (iterator < totalElements)
            {
                y++;
                iterator++;
            }

            WriteMoveValue(array, x, y, iterator);
            Console.WriteLine(array[x, y] + " RIGHT");
        }

        /// <summary>
        ///     The move up.
        /// </summary>
        public static void MoveUp()
        {
            Console.WriteLine(array[x, y] + " CURRENT");
            if (iterator < totalElements)
            {
                x--;
                iterator++;
            }

            WriteMoveValue(array, x, y, iterator);
            Console.WriteLine(array[x, y] + " UP");
        }

        /// <summary>
        /// The read array content - does read all the values row by row stored in the array
        /// </summary>
        public static void ReadArrayContent()
        {
            Console.WriteLine();
            for (int i = 0; i < rowLenght; i++)
            {
                for (int j = 0; j < colLenght; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }

                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            Console.WriteLine();
        }

        #endregion

        #region Methods

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        /// <exception cref="Exception">
        /// </exception>
        private static void Main(string[] args)
        {
            ReadArrayContent();

            if (rowLenght.Equals(colLenght))
            {
                int repeats = 1;
                int nextMove = 4;

                while (iterator <= 15)
                {
                    WriteMoveValue(array, x, y, iterator);
                    switch (nextMove)
                    {
                        case 1:

                            for (int a = 0; a < repeats; a++)
                            {
                                MoveUp();
                            }

                            nextMove = 2;
                            repeats = repeats + 1;

                            break;

                        case 2:

                            for (int a = 0; a < repeats; a++)
                            {
                                MoveLeft();
                            }

                            nextMove = 3;
                            break;

                        case 3:
                            for (int a = 0; a < repeats; a++)
                            {
                                MoveDown();
                            }

                            nextMove = 4;
                            repeats = repeats + 1;
                            break;

                        case 4:
                            for (int a = 0; a < repeats; a++)
                            {
                                MoveRight();
                            }

                            nextMove = 1;
                            break;
                    }
                }
            }
            else
            {
                throw new Exception("TABLICA NIE MA TAKICH SAMYCH DLUGOSCI WIERSZY I KOLUMN!");
            }

            ReadArrayContent();

            Console.ReadLine();
        }

        /// <summary>
        /// The write move value.
        /// </summary>
        /// <param name="array">
        /// The array.
        /// </param>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        /// <param name="iterator">
        /// The iterator.
        /// </param>
        private static void WriteMoveValue(int[,] array, int x, int y, int iterator)
        {
            array[x, y] = iterator;
            Console.WriteLine(array[y, x]);
        }

        #endregion
    }
}