using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP1
{
    /// <summary>
    /// класс для формирования рандомного человека
    /// </summary>
    public static class RandomPerson
    {
        #region Fields

        /// <summary>
        /// рандом
        /// </summary>
        private static Random _random=new Random();

        #endregion

        #region Methods

        /// <summary>
        /// Метод формирования рандомного человека
        /// </summary>
        /// <returns>экземпляр класса Person</returns>
        public static Person GetRandomPerson()
        {
            var maleNames = new String[]
            {
                "Max", "Alex", "Tommy","Tony",
                "Ben", "Carl", "Jonh", "James",
                "Pierce", "Paul", "Kevin", "Donald",
                "Conor", "Duncan", "Nathan", "Bill"
            };

            var femaleNames = new String[]
            {
                "Jennis", "Pamella", "Sarah", "Kate",
                "Jane", "Doris", "Clare", "Mary",
                "Julia", "Ann", "Cameron", "Jennofer",
                "Emma", "Jane", "Lucy", "Lisa"
            };

            var surnames = new String[]
            {
                "Smith", "Jones", "Miller", "Harrison",
                "Lucas", "Garnett", "Daniels", "Crawford",
                "Willson", "Marlboro", "Gomez", "Schnieder",
                "Gerrard", "Lampard", "Crews", "Craig"
            };

            var randomPerson = new Person();
            var genderNumber = _random.Next(1, 3);
            switch (genderNumber)
            {
                case 1:
                {
                    randomPerson.Gender = GenderType.Male;
                    randomPerson.FirstName = maleNames[_random.Next(1, 
                                                       maleNames.Length)];
                    break;
                }               
                case 2:
                {
                     randomPerson.Gender = GenderType.Female;
                     randomPerson.FirstName = femaleNames[_random.Next(1,
                                                          femaleNames.Length)];
                     break;
                }
            }

            randomPerson.Surname = surnames[_random.Next(1, surnames.Length)];

            randomPerson.Age = _random.Next(1, 123);

            return randomPerson;

        }

        #endregion

    }
}
