﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    public class invalidInput : Exception
    {
        public invalidInput(string message) : base(message)
        {

        }

    }
}
