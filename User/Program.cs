using System;
using System.Reflection;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Surname = "Ustymenko";
            user.Name = "Roman";
            user.Login = "nooploo";
            user.Age = 103;

            foreach (PropertyInfo property in user.GetType().GetProperties())
            {
                Console.WriteLine(property.Name + " : " + property.GetValue(user, null));
            }

            Console.ReadLine();
        }
    }
}
