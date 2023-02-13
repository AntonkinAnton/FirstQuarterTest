using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FirstQuarterTest
{
    /// <summary>
    /// Сборник моих методов
    /// </summary>
    public class MyMethods
    {
        public static void Header(string about)
        {
            Console.Clear();
            Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains \n");
            Console.WriteLine($"{about}\n");
        }

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

        public static void PrintArray(string[] array, string message)
        {
            System.Console.WriteLine(message);
            Console.WriteLine(string.Join(", ", array));
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

        public static string[] CreateStringArray(int size)
        {
            return new string[size];
        }

        public static string[] FreeSizedArr(string message)
        {
            string[] array = new string[0];
            System.Console.WriteLine(message);

            int i = 0;
            do
            {
                Array.Resize(ref array, array.Length + 1);
                array[i] = Console.ReadLine();
                i++;
            } while (array[i - 1] != String.Empty);
            Array.Resize(ref array, array.Length - 1);
            return array;
        }

        public static void SetFontColor(int clr)
        {
            ConsoleColor[] MyConsoleColors = new ConsoleColor[] { ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue,
                ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
                ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White,
                ConsoleColor.Yellow };

            Console.ForegroundColor = MyConsoleColors[clr];
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

                        SetFontColor(rnd.Next(0, 15));
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
