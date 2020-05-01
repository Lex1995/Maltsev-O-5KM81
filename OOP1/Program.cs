using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace OOP1
{
    //TODO: RSDN - исправлено
    /// <summary>
    /// Класс для тестирования
    /// библиотеки PersonLibrary
    /// </summary>
    public class Program
    {
        //TODO: RSDN - исправлено
        /// <summary>
        /// Точка вхождения в программу
        /// </summary>
        /// <param name="args">Аргументы</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.WriteLine("Creating two people's lists");

            var firstList = new PersonList();
            var secondList = new PersonList();

            Console.WriteLine("Adding people to the lists");

            var peopleForTheFirstList = new Person[]
            {
                new Person("Max", "Payne", 31, GenderType.Male),
                new Person("Mona", "Sax" , 25, GenderType.Female),
                new Person("Angelo" , "Punchinello", 47, GenderType.Male)
            };

            var peopleForTheSecondList = new Person[]
            {
                new Person("Carl", "Jones", 24, GenderType.Male),
                new Person("Tommy", "Vercetti", 35, GenderType.Male),
                new Person("Mercedes", "Cortez", 23, GenderType.Female)
            };

            foreach (Person person in peopleForTheFirstList)
            {
                firstList.AddPerson(person);
            }

            foreach (Person person in peopleForTheSecondList)
            {
                secondList.AddPerson(person);
            }

            PrintPersonLists(firstList, secondList);
            PrintEndingStrings();

            Console.WriteLine("Adding person to the first list");

            var newMaxPayneCharacter = new Person("Alex", "Bolder", 42, GenderType.Male);
            firstList.AddPerson(newMaxPayneCharacter);
            
            
            Console.WriteLine("Copying the second person from " +
                               "the fist list to the second one");
            secondList.AddPerson(firstList[1]);
            Console.WriteLine("Successful");
              
            PrintPersonLists(firstList, secondList);
            PrintEndingStrings();

            Console.WriteLine("Deleting the second person from the first list");
            firstList.DeleteByIndex(1);
            PrintPersonLists(firstList, secondList);
            PrintEndingStrings();

            Console.WriteLine("Clearing the second list");
            secondList.Clear();
            PrintPersonLists(firstList, secondList);
            PrintEndingStrings();

            Console.WriteLine("Creating random Person");
            secondList.AddPerson(RandomPerson.GetRandomPerson());
            PrintPersonLists(firstList, secondList);
            PrintEndingStrings();

            Console.WriteLine("Create person by console input");
            secondList.AddPerson(ConsoleProvider.EnterNewPerson());
            PrintPersonLists(firstList, secondList);
            PrintEndingStrings();


        }

        /// <summary>
        /// Вывод строк окончания действия 
        /// и ожидание нажатия клавиши для перехода
        /// к следующему действию
        /// </summary>
        private static void PrintEndingStrings()
        {
            Console.WriteLine("Successful");
            Console.WriteLine("\n----------\n");
            Console.ReadKey();
        }

        /// <summary>
        /// Вывод списков людей
        /// </summary>
        /// <param name="firstPersonList">первый список</param>
        /// <param name="secondPersonList">второй список</param>
        static void PrintPersonLists(PersonList firstPersonList,
                                      PersonList secondPersonList)
        {
            var personLists = new PersonList[]
            {
                firstPersonList,
                secondPersonList
            };

            for (int i = 0; i < personLists.Length; i++)
            {
                Console.WriteLine($"Список #{i + 1}\n");

                for (int j = 0; j < personLists[i].Length; j++)
                {
                    Console.WriteLine(personLists[i][j].GetInfo());
                }

                Console.WriteLine();
            }
        }
    }
}
