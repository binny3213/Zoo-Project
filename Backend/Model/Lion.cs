using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.project
{
    [Serializable]
    class Lion : Mammel
    {
        public int dm_roar_volume { get; set; }


        public Lion(string name, int age, Gender gender, bool is_carnivore, bool got_milk, int roar_volume)
            : base(name, age, gender, is_carnivore, got_milk)
        {
            dm_roar_volume = roar_volume;

        }

        public override string ToString()
        {
            return $"{base.ToString()}, roar volume: {dm_roar_volume}";
        }
    }
}
