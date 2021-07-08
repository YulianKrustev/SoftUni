using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeuple<TItemOne, TItemTwo, TItemThree>
    {
        private TItemOne itemOne;
        private TItemTwo itemTwo;
        private TItemThree itemThree;

        public Threeuple(TItemOne itemOne, TItemTwo itemTwo, TItemThree itemThree)
        {
            this.itemOne = itemOne;
            this.itemTwo = itemTwo;
            this.itemThree = itemThree;
        }

        public string GetInfo()
        {
            return $"{itemOne} -> {itemTwo} -> {itemThree}";
        }
    }
}
