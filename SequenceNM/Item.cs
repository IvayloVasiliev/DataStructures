using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceNM
{
    public class Item
    {
        public int value;
        public Item prevItem;

        public Item()
        {

        }

        public Item(int value, Item prevItem)
        {
            this.value = value;
            this.prevItem = prevItem;
        }
    }
}
