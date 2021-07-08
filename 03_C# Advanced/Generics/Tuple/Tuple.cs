using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<TItemOne, TItemTwo>
    {
        private TItemOne itemOne;
        private TItemTwo itemTwo;
        public Tuple(TItemOne itemOne, TItemTwo itemTwo)
        {
            this.itemOne = itemOne;
            this.itemTwo = itemTwo;
        }

        public string GetInfo()
        {
            return $"{itemOne} -> {itemTwo}";
        }
    }
}
