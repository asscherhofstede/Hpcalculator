using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calstack
{
    abstract class StackAbstract
    {
        public abstract int Count();
        public abstract void Push(int item);
        public abstract int Pop();

        public bool IsEmpty()
        {
            bool StackEmpty = false;
            int a = Count();
            if (a == 0)
            {
                StackEmpty = true;
            }
            return StackEmpty;
        }
    }
}
