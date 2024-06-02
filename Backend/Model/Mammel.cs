using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.project
{
    [Serializable]
    public abstract class Mammel : Animal
    {
        public bool dm_is_carnivore { get; set; }
        public bool dm_got_milk { get; set; }

        protected Mammel(string name, int age, Gender gender, bool is_carnivore, bool got_milk)
            : base(name, age, gender)
        {
            dm_is_carnivore = is_carnivore;
            dm_got_milk = got_milk;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, is carnivore?: {dm_is_carnivore}, got milk?: {dm_got_milk}";
        }
    }
}
