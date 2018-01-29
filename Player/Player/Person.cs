using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Person
    {
        /// <summary>
        /// Variable to store the person name
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Class constructor requires a string upon creation
        /// </summary>
        /// <param name="name"></param>
        public Person(string name)
        {
            Name = name;
        }

        /// <summary>
        /// CUses the Name variable to create a greeting for the person
        /// </summary>
        /// <returns></returns>
        public string GreetPerson()
        {
            return "Hello " + Name;
        }
    }


}