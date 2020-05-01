using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP1
{
    //TODO: XML - исправлено
    /// <summary>
    /// класс, реализующий список людей -
    /// объектов класса Person
    /// </summary>
    public class PersonList
    {
        #region Fields

        /// <summary>
        /// Список людей
        /// </summary>
        private Person[] _people;

        #endregion

        #region Properties
        //TODO: XML - исправлено
        /// <summary>
        /// Длина списка персон
        /// </summary>
        public int Length
        {
            get
            {
                return _people.Length;
            }
        }
        #endregion

        #region Indexator
        /// <summary>
        /// Возвращает человека из списка по индуксу
        /// </summary>
        /// <param name="index">Индекс человека в списке</param>
        /// <returns></returns>
        public Person this[int index]
        {
            get
            {
                if (index < 0 || index > Length - 1)
                {
                    throw new IndexOutOfRangeException($"Index must be above zero and than the " + 
                                                       $"size of the collection.");
                }
                return _people[index];
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Конструктор списка, инициализирующий пустой список людей
        /// </summary>
        public PersonList()
        {
            _people = new Person[0];
        }
        #endregion

        #region Methods

        /// <summary>
        /// Добавление человека в список
        /// </summary>
        /// <param name="person">Добавляемый человек в список</param>
        public void AddPerson (Person person)
        {
            var buffer = new Person[_people.Length + 1];
            for (int i = 0; i < buffer.Length - 1; i++)
            {
                buffer[i] = _people[i];
            }
            buffer[buffer.Length - 1] = person;
            _people = buffer;
        }
        
        /// <summary>
        /// Очистка списка
        /// </summary>
        public void Clear()
        {
            _people = new Person[0];
        }

        /// <summary>
        /// Удаление человека из списка по индексу
        /// </summary>
        /// <param name="personIndex">Индекс человека в списке</param>
        public void DeleteByIndex(int personIndex)
        {
            if (personIndex < 0 || personIndex > _people.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            int counter = 0;
            var buffer = new Person[_people.Length - 1];

            for (int i = 0; i < _people.Length; i++)
            {
                if (i != personIndex)
                {
                    buffer[counter] = _people[i];
                    counter++;
                }
            }
            _people = buffer;
        }

        /// <summary>
        /// Поиск индекса человека в списке
        /// </summary>
        /// <param name="person">Экземпляр объекта класса Person</param>
        /// <returns> Индекс человека в списке</returns>
        public int GetIndex (Person person)
        {
            for (int i=0; i<_people.Length; i++)
            {
                if (_people[i] == person)
                {
                    return i;
                }
            }
            throw new KeyNotFoundException("There is no such person in " + "this list.");
        }

        /// <summary>
        /// Удаление из списка по совпадению с переданным экземпляром класса Person
        /// </summary>
        /// <param name="person">Экземпляр класса Person</param>
        public void DeletePerson(Person person)
        {
            DeleteByIndex(GetIndex(person));
        }
        #endregion
    }
}
