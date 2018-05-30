using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WodApp
{
    public class Random
    {
        public int id { get; set; }

        public string ExerciseName { get; set; }

        public string ExerciseEquipment { get; set; }

        public string ExerciseMuscle { get; set; }

        public string ExerciseCardio { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ExerciseName} {ExerciseEquipment}";
            }
        }
    }
}
