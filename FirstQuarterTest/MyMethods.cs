using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstQuarterTest
{
    /// <summary>
    /// Сборник моих методов
    /// </summary>
    public class MyMethods
    {
        public static int GetNum(string message)
        {
            int num;
            do
            {
                System.Console.WriteLine(message);
            } while (!int.TryParse(Console.ReadLine(), out num));
            Console.WriteLine();
            return num;
        }

        public static void PrintArray(int[] array, string message)
        {
            System.Console.WriteLine(message);
            for (int i = 0; i < array.Length; i++)
            {

                System.Console.Write("{0,4}", array[i]);

            }
            Console.WriteLine("\n");
           

        }

        public static void PrintArray(double[] array, string message)
        {
            System.Console.WriteLine(message);
            for (int i = 0; i < array.Length; i++)
            {

                System.Console.Write("{0,5}", array[i]);

            }
            Console.WriteLine("\n");

        }
        public static void FillArrayRndm(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 10);
            }
        }

        public static void FillArrayRndm(double[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100) / 10.0;
            }
        }

        public static int[] CreateArray(int size)
        {
            return new int[size];
        }



        public static void SetFontColor(int clr)
        {
            switch (clr)
            {

                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 11:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 12:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 13:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 14:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 15:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

            }
        }

        public static async void RunningString(string endmessage, int delayMs)
        {
            Console.CursorVisible = false;
            endmessage += " ";
            Random rnd = new Random();

            while (true)
            {
                for (int i = 0; i < endmessage.Length; i++)
                {
                    Console.SetCursorPosition(endmessage.Length - 1 - i, Console.CursorTop);
                    for (int j = 0; j <= i; j++)
                    {
                        System.Console.Write(endmessage[j]);
                    }

                    await Task.Delay(delayMs);

                    if (i == endmessage.Length - 1)
                    {
                        for (int i1 = 0; i1 < endmessage.Length; i1++)
                        {
                            Console.SetCursorPosition(0, Console.CursorTop);
                            for (int j1 = i1 + 1; j1 < endmessage.Length; j1++)
                            {
                                System.Console.Write(endmessage[j1]);
                            }
                            await Task.Delay(delayMs);
                        }

                        SetFontColor(rnd.Next(1, 16));
                    }

                }
            }
        }

       public static void End()
        {
            Console.ReadKey();
            return;
        }
    }
}
