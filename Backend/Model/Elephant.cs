using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.project
{
    [Serializable]
    class Elephant : Mammel
    {
        public int dm_weight { get; set; }
        public bool dm_has_tusk { get; set; }


        public Elephant(string name, int age, Gender gender, bool is_carnivore, bool got_milk, int weight, bool has_tusk)
            : base(name, age, gender, is_carnivore, got_milk)
        {
            dm_weight = weight;
            dm_has_tusk = has_tusk;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, weight: = {dm_weight}, has tusk? {dm_has_tusk}";
        }
    }
}
