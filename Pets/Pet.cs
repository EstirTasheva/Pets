using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Pet
    {
        private string name;
        private string type;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Name cannot be null or whitespace.");
                }
                else
                {
                    name = value;
                }
            }
        }
        public string Type
        {
            get { return type; }
            set 
            {
                if (value == " ")
                {
                    throw new NullReferenceException();
                }
                else
                {
                    type = value;
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Age cannot be zero.");
                }
                else
                {
                    age = value;
                }
            }
        }
        public Pet(string name, string type, int age)
        {
            this.name = name;
            this.type = type;
            this.age = age;
        }

        public void PetInformation()
        {
            Console.WriteLine ($"Име: {Name}, Вид: {Type}, Възраст: {Age}");
        }
    }
}
