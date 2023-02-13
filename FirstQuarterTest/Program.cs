using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FirstQuarterTest
{
    internal class Program
    {
        static string[] FindLessStrings(string[] mainArray, int len)
        {
            string[] resultArray = new string[mainArray.Length];
            int resultLength = 0;

            for (int i = 0; i < mainArray.Length; i++)
            {
                if (mainArray[i].Length <= len)
                {
                    resultArray[resultLength] = mainArray[i];
                    resultLength++;
                }
            }
            Array.Resize(ref resultArray, resultLength);
            return resultArray;
        }
        static void Main(string[] args)
        {
            MyMethods.Header("Программа показывает все строки из массива, длинной <= 3");

            string[] firstArray = MyMethods.FreeSizedArr("Введите элементы массива. По завершению нажмите Enter");

            int taskLength = 3;

            string[] resultArray = FindLessStrings(firstArray, taskLength);

            MyMethods.PrintArray(resultArray, "Элементы из трех и менее символов:");

            MyMethods.RunningString("Для выхода нажмите любую клавишу...", 70);

            MyMethods.End();
        }
    }
}
