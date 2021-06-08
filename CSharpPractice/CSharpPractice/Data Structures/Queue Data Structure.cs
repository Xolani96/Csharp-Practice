using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice.Data_Structures
{
    public class QNode
    {
        public int key;
        public QNode next;

        public QNode(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
    public class Queue
    {
        public QNode front, rear;
        public Queue()
        {
            this.front = this.rear = null;
        }
        public void enqueue(int key)
        {
            QNode temp = new QNode(key);
            if(this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }

            this.rear.next = temp;
            this.rear = temp;
        }

        public void dequeue()
        {
            if (this.front == null)
                return;

            QNode temp = this.front;
            this.front = this.front.next;

            if (this.front == null)
                this.rear = null;
        }
    }
}
