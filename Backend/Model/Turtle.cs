using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.project
{
    [Serializable]
    class Turtle : Reptile
    {
        public bool dm_can_swim { get; set; }
        public int dm_speed { get; set; }

        public Turtle(string name, int age, Gender gender, bool is_cold_blooded, bool has_legs, bool can_swim, int speed)
             : base(name, age, gender, is_cold_blooded, has_legs)
        {
            dm_can_swim = can_swim;
            dm_speed = speed;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, can swim? = {dm_can_swim}, speed: {dm_speed}";
        }

    }
}
