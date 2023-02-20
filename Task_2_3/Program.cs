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
            //создаем экземпляр класса Employee
            Employee employee = new Employee();

            //Вводим имя сотрудника;
            Console.WriteLine("Введите имя сотрудника...");
            //передаем значение в экземпляк класса Employee в поле name;
            employee.Name = Convert.ToString(Console.ReadLine());


            //Вводим фамилию сотрудника;
            Console.WriteLine("Введите фамилию сотрудника...");
            //передаем значение в экземпляр класса Employee в поле surname;
            employee.Sur_name = Convert.ToString(Console.ReadLine());
            

            Console.WriteLine("Введите должность сотрудника:1-помощник,2-специалист,3-менеджер");
            int post = Convert.ToInt32(Console.ReadLine());
            //employee.Post_1(post);

            Console.WriteLine("Введите стаж сотрудника:1-1 год,2-от 1 до 5 лет,3-5 лет и больше");
            int experience = Convert.ToInt32(Console.ReadLine());
            employee.Post_1(post,experience);

            Console.WriteLine($"Сотрудник {employee.Name} {employee.Sur_name}");
            Console.WriteLine($"должность {employee.Post},стаж {employee.Experience}");
            Console.WriteLine($"К выплате : {employee.Salary}");

            Console.ReadKey();
        }
    }
}
