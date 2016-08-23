using System.Collections;

namespace DataStructures
{
    public class CircularBuffer
    {
        private byte[] buffer;
        private int head;
        private int tail;

        public CircularBuffer () : this(capacity:3)
	    {
	    }
        
        public CircularBuffer(int capacity)
        {
            buffer = new byte[capacity + 1];
            head = 0;
            tail = 0;
        }

        public void Write(byte value)
        {
            buffer[tail] = value;
            tail = (tail + 1) % buffer.Length;
            if (tail == head)
            {
                head = (head + 1) % buffer.Length;
            }
        }

        public byte Read()
        {
            var result = buffer[head];
            head = (head + 1) % buffer.Length;
            return result;
        }

        public int Capacity 
        { 
            get { return buffer.Length; } 
        }

        public bool IsEmpty 
        {
            get { return tail == head; }
        }

        public bool IsFull 
        {
            get { return (tail + 1) % buffer.Length == head;  }
        }       
    }
}
