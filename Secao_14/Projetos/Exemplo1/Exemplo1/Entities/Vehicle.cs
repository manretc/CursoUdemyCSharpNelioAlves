﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1.Entities {
    internal class Vehicle {
        public string Model { get; set; }

        public Vehicle(string model) {
            Model = model;
        }
    }
}
