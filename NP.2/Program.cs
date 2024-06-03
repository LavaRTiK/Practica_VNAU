using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Завдання
Вивести на екран наступні дані використовуючи змінні:
1. Ваше Прізвище, ім’я, по-батькові, дату народження (повністю);
2. Ваш вік;
3. Дату вступу до ВНЗ;
4. Вашу групу;
5. Сьогоднішні дату (повністю);
6. Прізвище, ім’я, по-батькові Вашого викладача.
            */

            string firstname = "Павло ";
            string surname = "Ярошенко ";
            string midname = "Павлович ";
            string datanarojenja = "27.07.2003 ";
            string old = "20 ";
            string unviData = "30.09.2023";
            string group = "KH22-1 ";
            DateTime dateTime = DateTime.Now;
            string teacher = "Чіков Ілля Анатолівич ";
            Console.WriteLine(firstname,surname,midname,datanarojenja,old,unviData,group,datanarojenja,dateTime.ToString());
        }
    }
}
