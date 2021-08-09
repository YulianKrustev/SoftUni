using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty() => this.Count == 0;

        public void AddRange(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                this.Push(item);
            }
        }
    }
}
