using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.project
{
    [Serializable]
    public abstract class Animal
    {
        public enum Gender
        {
            Male,
            Female
        }

        
        public string dm_name { get; set; }

        public int dm_age { get; set; }
        public Gender dm_gender { get; set; }

        public Animal(string name, int age, Gender gender)
        {
            dm_name = name;
            dm_age = age;
            dm_gender = gender;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name.ToUpper()}, name: {dm_name}, age: {dm_age}, gender: {dm_gender}";
        }

    }
}
