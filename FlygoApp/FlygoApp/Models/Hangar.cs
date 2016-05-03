﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlygoApp.Models
{
    public class Hangar
    {
        public int Id { get; set; }
        public string Placering { get; set; }

        public Hangar(int id, string placering)
        {
            Id = id;
            Placering = placering;
        }

        public Hangar()
        {
            
        }

        public override string ToString()
        {
            return $"{Placering}";
        }
    }
}