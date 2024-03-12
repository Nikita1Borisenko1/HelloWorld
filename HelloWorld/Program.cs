using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; /// Прописка консоли чтобы каждый раз не писать
namespace HellowWorldConsoleApp
{
    class Program
    {
        static void Main(string[] args) /// точка входа обязательная
        {
            WriteLine("Привет мир!"); /// Вывод текста
            ReadKey(); /// Задержка экрана
        }
    }
}