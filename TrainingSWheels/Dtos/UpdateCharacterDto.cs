﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingSWheels.Models;

namespace TrainingSWheels.Dtos
{
    public class UpdateCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strenght { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Warrior;
    }
}
