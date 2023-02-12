using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_3
{
    class Program
    {
        /*
         Задание 3 
         Используя Visual Studio, создайте проект по шаблону Console Application. 
         Требуется: 
         1-Создать класс Employee. 
         2-В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и 
           инициализирует поля, соответствующие фамилии и имени сотрудника. 
         3-Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор. 
         4-Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), 
           оклад и налоговый сбор.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя сотрудника...");
            string name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите фамилию сотрудника...");
            string surname = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите должность сотрудника:1-помощник,2-специалист,3-менеджер");
            int post = Convert.ToInt32(Console.ReadLine());
            switch (post)
            {
                case 1:
                    Post_assistant();
                    break;
                case 2:
                    Post_specialist();
                    break;
                case 3:
                    Post_manager();
                    break;
                default:
                    break;
            }


            Employee employee = new Employee(name,surname);

            Console.ReadKey();
        }
    }
}
