using System;

namespace Employee
{
    internal class Employee
    {
        public string name;
        public string surname;
        public int experience;
        public int salary;
        public int tax;
        public string position;
        string[] positions = { "min", "mid", "max" };

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            Random random = new Random();
            this.experience = random.Next(0, 10);
            this.position = positions[random.Next(0, 3)];

            if (this.position == "min")
            {
                this.salary = random.Next(500, 700);

            }
            else if (position == "mid")
            {
                this.salary = random.Next(1200, 2000);
                this.tax = 10;
            }
            else
            {
                this.salary = random.Next(2500, 3000);
                this.tax = 12;
            }


            if (this.experience < 1) this.salary += 50;
            else if (this.experience <= 5) this.salary += 100;
            else this.salary += 150;

        }

        public int Salary
        {
            get
            {
                return this.salary - this.salary / 100 * this.tax;
            }
        }


    }
}


