using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWalker
{
    interface RandomWalkObserver
    {
        void Moved(RandomWalkEvent);
    }
}
