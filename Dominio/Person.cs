﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public List<subject> subjects { get; set; }
    }
}
