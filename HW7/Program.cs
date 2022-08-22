using HW7;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW7

{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"Сотрудники.txt";

            Repository rep = new Repository(path);

            Console.WriteLine("Нажмите 1, чтобы вывести данные на экран.");
            Console.WriteLine("Нажмите 2, чтобы заполнить данные нового сотрудника");

            int k = int.Parse(Console.ReadLine());

            while (k == 2)
            {
                rep.PrintAllWorkers();
                break;
            }




            //while (k == 1)
            //{
            //    rep.GetAllWorkers();
            //    break;
            //}


            //while (k == 3)
            //{
            //    rep.SearchById();
            //    break; 
            //}


        }
    }
}


