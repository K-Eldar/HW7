using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class Repository
    {
        private string Path;

        public Repository(string path)
        {
            this.Path = path;
        }

        public Worker[] GetAllWorkers()
        {
            using (StreamReader sr = new StreamReader(Path, Encoding.Unicode))
            {
                string line;
                int count = File.ReadAllLines(Path).Length;
                var workers = new Worker[count];
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('#');

                    var worker = new Worker()
                    {
                        Id = data[0],
                        CreateDate = data[1],
                        FIO = data[2],
                        Tall = data[3],
                        Age = data[4],
                        DateOfBirth = data[5],
                        PlaceOfBirthday = data[6],
                    };
                    workers[count] = worker;
                }
                return workers;
            }
        }


        public void AddWorker()
        {

            Console.Write("Введите данные нового сотрудника: ");
            using (StreamWriter sw = new StreamWriter("Сотрудники.txt", true, Encoding.Unicode))
            {
                char key = '1';

                do
                {
                    Worker w = new Worker();

                    Console.Write("\nВведите ID нового работника: ");
                    w.Id = $"{Console.ReadLine() + '#'}";

                    w.CreateDate = DateTime.Now.ToShortTimeString();
                    Console.WriteLine($"Время и дата записи {w.CreateDate}");

                    Console.Write("\nВведите Ф.И.О. нового работника: ");
                    w.FIO = $"{Console.ReadLine() + '#'}";

                    Console.Write("\nВведите возраст нового работника: ");
                    w.Age = $"{Console.ReadLine() + '#'}";

                    Console.Write("\nВведите рост нового работника: ");
                    w.Tall = $"{Console.ReadLine() + '#'}";

                    Console.Write("\nВведите дату рождения нового работника: ");
                    w.DateOfBirth = $"{Console.ReadLine() + '#'}";

                    Console.Write("\nВведите место рождения нового работника: ");
                    w.PlaceOfBirthday = $"{Console.ReadLine() + '#'}";

                    sw.WriteLine(w);
                    Console.Write("Если хотите добавить еще одного сотрудника, нажмите 1, если нет, то 2."); key = Console.ReadKey(true).KeyChar;

                } while (char.ToLower(key) == '1');
            }
        }

        /// <summary>
        /// Получить всех сотрудников
        /// </summary>
        /// <returns></returns>
        //public Worker[] GetAllWorkers()
        //{
        //    using (StreamReader sr = new StreamReader(Path, Encoding.Unicode))
        //    {
        //        string line;
        //        var workers = new Worker[] { };
        //        int index = 0;
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            string[] data = line.Split('#');

        //            var worker = new Worker()
        //            {
        //                Id = data[0],
        //                CreateDate = data[1],
        //                FIO = data[2],
        //                Tall = data[3],
        //                Age = data[4],
        //                DateOfBirth = data[5],
        //                PlaceOfBirthday = data[6],
        //            };
        //            workers[index++] = worker;
        //        }

        //        return workers;
        //    }
        //}

        /// <summary>
        /// Распечатать всех сотрудников
        /// </summary>
        public void PrintAllWorkers()
        {
            var workers = GetAllWorkers();
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.Print());
            }
        }

        //public void SearchById()
        //{
        //    Console.WriteLine("Введите ID");
        //    string id = Console.ReadLine() ?? "";

        //    var workers = GetAllWorkers();

        //    string idNumber = workers.array.First(item => item.ID == id);

        //    Console.WriteLine("\n" + id.Split('#'));
        //}
    }





}
