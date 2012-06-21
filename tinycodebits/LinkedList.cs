using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tinycodebits
{

    public class LinkedItem
    {
        public object Value { get; set; }
        public LinkedItem Next { get; set; }
        public LinkedItem Previous { get; set; }

        //let's define some user friendly operators 
        public static LinkedItem operator ++(LinkedItem item)
        {
            if (item == null)
                return null;
            return item.Next;
        }
        public static LinkedItem operator --(LinkedItem item)
        {
            if (item == null)
                return null;
            return item.Previous;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
   
    
    public class LinkedList
    {
        LinkedItem _start;
        private LinkedItem _last;


        public void ConstrainedReverse()
        {
            //if our list was truly a linked list not a double linked list
            LinkedItem currentItem = _start;
            LinkedItem previousItem = null;
            _last = _start;


            while (currentItem != null)
            {
                _start = currentItem;
                var nextItem = currentItem.Next;
                currentItem.Next = previousItem;
                previousItem = currentItem;
                currentItem = nextItem;
            }
            
        }
        public void Reverse()
        {
            LinkedItem currentItem = _last;
            _last = _start;
            _start = currentItem;

            while (currentItem != null)
            {
                LinkedItem previousItem = currentItem.Previous;
                currentItem.Previous = currentItem.Next;
                currentItem.Next = previousItem;
                currentItem = previousItem;
            }
        }


        public void Add(object value)
        {
            LinkedItem addedItem = new LinkedItem { Value = value, Next = null };
            if (_last == null)
            {
                _last = addedItem;
                _last.Previous = null;
                //keep track of that very first item to make it easy to traverse the list
                _start = _last;
                return;
            }

            _last.Next = addedItem;
            addedItem.Previous = _last;
            _last = addedItem;
        }

        public object Remove(object value)
        {
            LinkedItem previous = _start;
            object removedObject = null;

            while (previous != null)
            {
                if (previous.Next.Value == value)
                {
                    removedObject = previous.Next.Value;
                    previous.Next = previous.Next.Next;
                    return removedObject;
                }
                previous = previous.Next;
            }
            return removedObject;
        }

        public object Pop()
        {
            if (_last == null)
                return null;

            object poppedValue = _last.Value;
            _last = _last.Previous;
            _last.Next = null;
            return poppedValue;
        }

        public void Push(object value)
        {
            Add(value);
        }

        public void AddAt(object value, int index)
        {
            LinkedItem currentItem = getAt(index);
            LinkedItem itemToAdd = new LinkedItem { Value = value };

            if (currentItem == null)
                throw new ArgumentException("Index provided is invalid: list does not have that many items in it");

            insertBefore(currentItem, itemToAdd);
        }

        public int Count 
        { 
            get 
            {
                LinkedItem currentItem = _start;
                int count = 0;
                while (currentItem != null)
                {
                    currentItem = currentItem.Next;
                    count++;
                }

                return count; 
            }
        }

        public object GetAt(int position)
        {

            LinkedItem currentItem = getAt(position);
            if (currentItem == null)
                return null;
            return currentItem.Value;
        }

        //public override string ToString()
        //{
        //    StringBuilder strBuilder = new StringBuilder();
        //    LinkedItem currentItem = _start;
        //    while (currentItem != null )
        //    {
        //        if (strBuilder.Length > 0)
        //            strBuilder.Append(", ");
        //        strBuilder.Append(currentItem.ToString());
        //        currentItem = currentItem.Next;
        //    }

        //    return strBuilder.ToString();

        //}

        private void insertBefore(LinkedItem targetItem, LinkedItem itemTobeAdded)
        {
            if (targetItem == null)
                return;

            LinkedItem previousItem = targetItem.Previous;

            previousItem.Next = itemTobeAdded;
            itemTobeAdded.Next = targetItem;
            targetItem.Previous = itemTobeAdded;
        }

        private LinkedItem getItem(object value)
        {
            LinkedItem currentItem = _start;
            while (currentItem != null && currentItem.Value != value)
            {
                currentItem = currentItem.Next;
            }

            return currentItem;
        }


        private LinkedItem getAt(int position)
        {
            LinkedItem currentItem = _start;
            int count = 0;
            while (currentItem != null && count < position)
            {
                currentItem = currentItem.Next;
                count++;
            }

            return currentItem;
        }
    }
}
