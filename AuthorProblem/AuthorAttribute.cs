using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace AuthorProblem
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]

    public class AuthorAttribute : Attribute
    {

        public AuthorAttribute(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
