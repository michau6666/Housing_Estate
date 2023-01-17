using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    class Person
    {
        private string name;
        private string surname;
        private int age;
        private Flat xFlat;
        public Flat XFlat
        {
            get { return xFlat; }
            set { this.xFlat = value; }
        }

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return string.Format($"name: { name }\n surname: { surname}\n age: {age}");
        }

    }
}
