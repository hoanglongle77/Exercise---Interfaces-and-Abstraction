﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Interfaces_and_Abstraction.Problem_3
{
    internal interface ISmartphone : IStationaryPhone
    {
        string Browse(string url);
    }
}
