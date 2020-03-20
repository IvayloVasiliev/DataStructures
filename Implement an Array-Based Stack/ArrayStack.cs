using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Implement_an_Array_Based_Stack
{
    public class ArrayStack<T> 
    {
        private const int InitialCapacity = 4;

        private T[] elements;
        public int Count { get; private set; }

        public bool IsReadOnly => throw new NotImplementedException();

        public ArrayStack()
        {
            this.elements = new T[InitialCapacity];
            this.Count = 0;
        }

        public void Push(T element)
        {
            int index = this.Count;
            this.elements[index] = element;

            this.Count++;

            if (this.Count >= this.elements.Length)
            {
                this.Grow();
            }

        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new ArgumentOutOfRangeException("Stack is empty!");
            }

            int index = this.Count - 1;

            T element = this.elements[index];

            this.Count--;

            return element;
        }

        public T[] ToArray()
        {
            T[] toReturn = new T[Count];
            int index = 0;

            for (int i = toReturn.Length -1; i >= 0; i--)
            {
                toReturn[index++] = this.elements[i];
            }

            return toReturn;
        }

        private void Grow()
        {
            T[] newArray = new T[2 * this.Count];

            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.elements[i];
            }
            elements = newArray;
        }

       
    }
}
