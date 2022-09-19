using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    public class Animal
    {
        string name;
        int age;
        string color;

        public Animal()
        {
            this.name = "Dog";
            this.age = 12;
            this.color = "Brown";
        }

        public string getAnimal()
        {
            return this.name;
        }
    }
}
