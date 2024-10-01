using System;
using System.Collections.Generic;
using System.Text;

namespace BeeBuisness
{
    interface IWorker
    {
        string Job { get; }
        void WorkTheNextShift();
    }
}
