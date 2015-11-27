using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanStudentandWorker
{
    class MainClass
    {
        private static void Main()
        {
            var students = new List<Student>
            {
                new Student("Martin", "Qnkov", 1993),
                new Student("Borislav", "Krumov", 1990),
                new Student("Niki", "Mihov", 1850),
                new Student("Denislav", "Angelov", 2000)
            };

            var workers = new List<Worker>
            {
                new Worker("Yordan", "Lektora", 1000, 5),
                new Worker("Ivan", "Yankov", 2000, 10),
                new Worker("Edu", "Georgiev", 500, 2),
                new Worker("Angel", "Krumov", 3000, 13)
            };

            var orderedStudents = students.OrderBy(x => x.FacultyNumber).ToList();
            var orderedWorkers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();

            var resultList = 
                orderedStudents.Concat(orderedWorkers.Cast<Human>()).
                OrderBy(x => x.Name).
                ThenBy(x => x.LastName).
                ToList();

            foreach (var person in resultList)
            {
                Console.WriteLine(person);
            }
        }
    }
}