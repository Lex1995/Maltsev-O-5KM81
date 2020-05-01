using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace OOP1
{
    //TODO: Комментарий - исправлено
    /// <summary>
    /// класс Person,
    /// реализующий описание человека
    /// </summary>
    public class Person
    {
        #region Fields
        /// <summary>
        /// Имя
        /// </summary>
        private string _fistName;

        /// <summary>
        /// Фамилия
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст
        /// </summary>
        private int _age; 

        /// <summary>
        /// Пол
        /// </summary>
        private GenderType _gender;

        #endregion

        #region Properties
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName
        {
            get
            {
                return _fistName;
            }
            set
            {
                NameChecking(value);
                _fistName = NameSpelling(value);
            }
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                NameChecking(value);
                _surname = NameSpelling(value);
            }
        }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0 || value > 122)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 122");
                } 
                _age = value;
            }
        }

        /// <summary>
        /// Пол
        /// </summary>
        public GenderType Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// Персона
        /// </summary>
        public Person() { }

        /// <summary>
        /// Человек
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="gender">Пол</param>
        public Person(string firstName, string surname, int age, GenderType gender)
        {
            FirstName = firstName;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Проверить имя/фамилию на корректность
        /// </summary>
        /// <param name="value"></param>
        private void NameChecking(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException($"{nameof(value)} is null or empty");
            }
            if (!IsNameCorrect(value))
            {
                throw new FormatException($"{nameof(value)} must containt only Russian or English letters");
            }
        }

        /// <summary>
        /// Метод для автоматического преобразования введенного имени/фамилии в правильный регистр
        /// </summary>
        /// <param name="wordToCorrect"></param>
        /// <returns> Преобразованную строку</returns>
        private static string NameSpelling (string wordToCorrect)
        {
            string[] buffer = wordToCorrect.Split('-');
            wordToCorrect = null;
            string _firstLetter;
            for (int i=0; i<buffer.Length; i++)
            {
                _firstLetter = buffer[i].First().ToString().ToUpper();
                buffer[i] = _firstLetter + buffer[i].Substring(1);
                wordToCorrect += $"{buffer[i]}-";
            }
            return wordToCorrect.Substring(0, wordToCorrect.Length - 1);
        }

        /// <summary>
        /// Проверить строку на наличие в ней только букв русского и латинского алфавита 
        /// </summary>
        /// <param name="input"> параметр для проверки</param>
        /// <returns> Результат проверки параметра на соответствие</returns>
        private static bool IsNameCorrect (string input)
        {
            var expressionRegex = "(([А-Я]|[а-я]|[A-Z]|[a-z])+)";
            var nameRegex = new Regex($"^{expressionRegex}((-)?){expressionRegex}$");
            if (!nameRegex.IsMatch(input))
            {
                return false;
            }
            return true;
        }

        //TODO: XML - исправлено
        /// <summary>
        /// формирование информации о человека
        /// </summary>
        /// <returns>строку с именем, фамилией
        /// возрастом и полом человека</returns>
        public string GetInfo()
        {
            return $"Имя: {FirstName}\nФамилия: {Surname}\n" +
                   $"Возраст: {Age}\nПол:{Gender}";
        }
        #endregion
    }
}

