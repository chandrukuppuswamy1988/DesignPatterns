using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Context
    {
        public const int start = 5;
        public int Counter = 5;

        IStrategy strategy = new Strategy1();

        // Algorithm invokes a strategy method
        public int Algorithm()
        {
            return strategy.Move(this);
        }

        // Changing strategies
        public void SwitchStrategy() // CK : this can be complex selection logic
        {
            if (strategy is Strategy1)
                strategy = new Strategy2();
            else
                strategy = new Strategy1();
        }


    }
}
