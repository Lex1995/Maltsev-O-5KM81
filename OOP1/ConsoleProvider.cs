using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP1
{
    //TODO: Именование + static - исправлено
    /// <summary>
    /// Ввод данных через консоль
    /// </summary>
    public static class ConsoleProvider
    {
        /// <summary>
        /// Создание нового человека с вводом данных из консоли
        /// </summary>
        /// <returns>Экземпляр класса Person</returns>
        public static Person EnterNewPerson()
        {
            var createdPerson = new Person();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write($"{nameof(createdPerson.FirstName)}: ");
                    createdPerson.FirstName=Console.ReadLine();
                }),

                new Action(() =>
                {
                    Console.Write($"{nameof(createdPerson.Surname)}: ");
                    createdPerson.Surname=Console.ReadLine();
                }),

                new Action(() =>
                {
                    Console.Write($"{nameof(createdPerson.Age)} (0-122): ");
                    createdPerson.Age=int.Parse(Console.ReadLine());
                }),

                new Action(() =>
                {
                    Console.Write($"{nameof(createdPerson.Gender)} " +
                                  $"(Male/Female): ");
                    var buffer=Console.ReadLine();
                    buffer=buffer.First().ToString().ToUpper()
                           +buffer.Substring(1);
                    createdPerson.Gender=(GenderType)Enum.Parse(
                                        typeof(GenderType),buffer);

                }),
            };

            actions.ForEach(SetValue);
            return createdPerson;

        }

        /// <summary>
        /// Задание значений при пользовательском вводе
        /// </summary>
        /// <param name="action"> Делегат с заданием параметра</param>
        public static void SetValue(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (ArgumentException argumentException)
                {
                    Console.WriteLine($"\n{argumentException.Message}\n");
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine($"\n{formatException.Message}\n");
                }
                catch(InvalidOperationException invalidOperationException)
                {
                    Console.WriteLine($"\n{invalidOperationException.Message}\n");
                }
            }
        }
    }
}
