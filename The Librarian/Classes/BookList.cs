using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Librarian
{
    public class BookList<T>
    {
        private class BookNode
        {
            public T Element { get; set; }
            public BookNode NextBook { get; set; }
            public BookNode PreviousBook { get; set; }

            public BookNode(T element)
            {
                this.Element = element;
                NextBook = null;
                PreviousBook = null;
            }
            public BookNode(T element, BookNode prevNode, BookNode nextNode)
            {
                this.Element = element;
                //this.NextBook =nextNode;
                nextNode.PreviousBook= this;
                prevNode.NextBook = this;
                //this.PreviousBook = prevNode;
            }
        }
        private int count;
        private BookNode head;
        private BookNode tail;

        public BookList()
        {
            this.head = null;
            this.tail = null;
            count = 0;
        }

        /// <summary>Add element at the end of the list</summary>
        /// <param name="item">The element to be added</param>
        public void Add(T item)
        {
            if (this.head == null)
            {
                // We have an empty list -> create a new head and tail
                this.head = new BookNode(item);
                this.tail = this.head;
            }
            else
            {
                // We have a non-empty list -> append the item after tail
                BookNode newNode = new BookNode(item, this.tail,this.head);
                this.tail = newNode;
            }
            this.count++;
        }

        public int IndexOf(T item)
        {
            int index = 0;
            BookNode currentNode = this.head;
            while (currentNode != null)
            {
                if (object.Equals(currentNode.Element, item))
                {
                    return index;
                }
                currentNode = currentNode.NextBook;
                index++;
            }
            return -1;

        }
        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }
                BookNode currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextBook;
                }
                return currentNode.Element;
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }
                BookNode currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextBook;
                }
                currentNode.Element = value;
            }
        }
        //

    }
}
