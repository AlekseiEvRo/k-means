﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_means.DataClasses
{
    internal class Cluster
    {
        public int Id { get; set; }
        public Color Color { get; set; }
        public Point Position { get; set; }
    }
}
