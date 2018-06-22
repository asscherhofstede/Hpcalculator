using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calstack
{
    class ArrayStack : StackAbstract
    {
        private int[] arry = new int[Presistence.Num];
        private int count = 0;


        public override int Count()
        {
            Presistence.Num = Count();
            return Presistence.Num;
            
        }

        public override void Pop(int item)
        {
            throw new NotImplementedException();
        }

        public override void Push(int item)
        {
            arry[count] = item;
            count++;
        }
    }
}
