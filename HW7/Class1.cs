using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public struct Worker
    {
        public string Id { get; set; }
        public string CreateDate { get; set; }
        public string FIO { get; set; }
        public string Tall { get; set; }
        public string Age { get; set; }
        public string DateOfBirth { get; set; }
        public string PlaceOfBirthday { get; set; }

        public Worker(string Id, string CreateDate, string FIO, string Tall, string Age, string DateOfBirth, string PlaceOfBirthday)
        {
            this.Id = Id;
            this.CreateDate = CreateDate;
            this.FIO = FIO;
            this.Tall = Tall;
            this.Age = Age;
            this.DateOfBirth = DateOfBirth;
            this.PlaceOfBirthday = PlaceOfBirthday;
        }





        public string Print()
        {
            return $"ID: {Id} ФИО: {FIO} Рост: {Tall} Возраст:{Age} Дата рождения: {DateOfBirth}  Место рождение: {PlaceOfBirthday}";
        }
    }
}