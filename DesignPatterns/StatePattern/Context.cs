﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Context
    {
        public const int limit = 10;
        public IState State { get; set; }
        public int Counter = limit;
        public int Request(int n)
        {
            if (n == 2)
                return State.MoveUp(this);
            else
                return State.MoveDown(this);
        }

    }
}
