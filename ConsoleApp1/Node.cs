using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Node<T>
    {
        private T value;
        private Node<T> next;
        public Node(T value)
        {
            this.value = value;
            next = null;
        }

        public Node(T value, Node<T> node)
        {
            this.value= value;
            this.next = next;
        }

        public T GetValue() { return value; }
        public void SetValue(T value) { this.value = value;}
        public Node<T> GetNext() { return next;}
        public void SetNext(Node<T> next) {  this.next = next;}

        public bool HasNext()
        {
            return this.next != null;
        }
    }
}
