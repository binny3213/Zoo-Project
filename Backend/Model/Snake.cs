using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.project
{
    [Serializable]
    class Snake : Reptile
    {
        public enum SkinColor
        {
            White,
            Black,
            Red,
            Green,
            Yellow,
            Blue,
            Purple,
            Pink,
            Orange
        }

        public SkinColor dm_skin_color { get; set; }
        public bool dm_is_venomous { get; set; }


        public Snake(string name, int age, Gender gender, bool is_cold_blooded, bool has_legs,
            SkinColor skin_color, bool is_venomous)
            : base(name, age, gender, is_cold_blooded, has_legs)
        {
            dm_skin_color = skin_color;
            dm_is_venomous = is_venomous;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, skin color: = {dm_skin_color}, is venomous? {dm_is_venomous}";
        }
    }
}
