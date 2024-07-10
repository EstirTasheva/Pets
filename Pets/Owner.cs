using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Owner
    {
        private string name;
        private int age;

        public string Name
        { 
            get { return name; }
            set { name = value; }
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

        public Owner(string name, int age)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty.");
            }
            this.name = name;
            this.age = age;
        }
        public void OwnerInformation()
        {
            Console.WriteLine($"Име: {Name}, Възраст: {Age}");
        }
    }
}
