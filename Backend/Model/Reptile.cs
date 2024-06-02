using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.project
{
    [Serializable]
    public abstract class Reptile : Animal
    {
        public bool dm_is_cold_blooded { get; set; }
        public bool dm_has_legs { get; set; }



        protected Reptile(string name, int age, Gender gender, bool is_cold_blooded, bool has_legs)
            : base(name, age, gender)
        {
            dm_is_cold_blooded = is_cold_blooded;
            dm_has_legs = has_legs;

        }

        public override string ToString()
        {
            return $"{base.ToString()}, is cold blooded? = {dm_is_cold_blooded}, has legs? {dm_has_legs}";
        }
    }
}
