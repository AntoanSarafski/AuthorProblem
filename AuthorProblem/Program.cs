using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace AuthorProblem
{
    [Author("Antoan")]
    [Author("Antoana")]
    public class StartUp
    {
        [Author("Vanio")]
        public static void Main(string[] args)
        {
            Type type = typeof(StartUp);

            foreach (var method in type.GetMethods((BindingFlags) 60))
            {
                
                AuthorAttribute[] attributes = method.GetCustomAttributes<AuthorAttribute>().ToArray();

                foreach (var attr in attributes)
                {
                    Console.WriteLine($"{method.Name} is written by {attr.Name}");
                }

            }
        }

        [Author("Pepi")]
        public static void OtherMethod()
        {

        }
    }
}
