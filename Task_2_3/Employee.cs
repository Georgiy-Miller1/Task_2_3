using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_3
{
    class Employee
    {
        string name, sur_name,post;
        double salary;
        int experience;

        //создаем конструктор по умолчанию;
        public Employee()
        {

        }

        //создаем пользовательский конструктор;
        public Employee(string name,string sur_name,string post, int experience,double salary)
        {
            this.name = name;
            this.sur_name = sur_name;
            this.post = post;
            this.experience = experience;
            this.salary = salary;
        }

        //создаем свойство Name для присвоения значения полю name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Sur_name
        {
            set
            {
                if(sur_name == null)
                    Console.WriteLine("Пустое поле...");
                sur_name = value;
            }
            get
            {
                if(sur_name == null)
                    Console.WriteLine("Пустое поле...");
                return sur_name;
            }
        }

        //создаем свойство Post для присвоения значения полю post;
        public string Post
        {
            set
            {
                if (value != null)
                    post = value;
            }

            get
            {
                if (post == null)
                    post = "Незаполненное поле";
                return post;
            }
        }

        public int Experience
        {
            get { return experience; }
        }


        public double Salary
        {
            get { return salary; }
        }

 

        public void Post_1(int post,int experience)
        {
            //Поле присвоения значения заработной платы относительно должности;
            double salary_koef = 0;

            switch (post)
            {
                case 1://помощник
                    salary_koef *= 0.8;
                    break;
                case 2://специалист
                    salary_koef *= 1;
                    break;
                case 3://менеджер
                    salary_koef *= 1.2;
                    break;
                default:
                    break;
            }

            switch (experience)
            {
                case 1://стаж 1 год
                    salary = salary_koef *= 1;
                    break;
                case 2://стаж 2-5 лет
                    salary = salary_koef *= 1.2;
                    break;
                case 3://стаж больше 5 лет
                    salary = salary_koef *= 1.5;
                    break;
                default:
                    break;
            }
        }
    }
}
