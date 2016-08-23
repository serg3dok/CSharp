using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class CircularBufferTests
    {
        [TestMethod]
        public void New_Buffer_Is_Empty()
        {
            var buffer = new CircularBuffer();
            Assert.IsTrue(buffer.IsEmpty);
        }

        [TestMethod]
        public void Three_Element_Buffer_Is_Full_After_Three_Writes()
        {
            var buffer = new CircularBuffer(capacity: 3);
            buffer.Write(1);
            buffer.Write(2);
            buffer.Write(4);
            Assert.IsTrue(buffer.IsFull);
        }

        [TestMethod]
        public void First_In_First_Out_When_Not_Full()
        {
            var buffer = new CircularBuffer(capacity: 3);
            byte value1 = 1;
            byte value2 = 2;

            buffer.Write(value1);
            buffer.Write(value2);

            Assert.AreEqual(value1, buffer.Read());
            Assert.AreEqual(value2, buffer.Read());
            Assert.IsTrue(buffer.IsEmpty);
        }

        [TestMethod]
        public void Overwrites_When_More_Than_Capacity()
        {
            var buffer = new CircularBuffer(capacity: 3);
            var values = new[] { 1, 2, 3, 4, 5 };

            foreach (byte value in values)
            {
                buffer.Write(value);
            }

            Assert.IsTrue(buffer.IsFull);
            Assert.AreEqual(values[2], buffer.Read());
            Assert.AreEqual(values[3], buffer.Read());
            Assert.AreEqual(values[4], buffer.Read());
            Assert.IsTrue(buffer.IsEmpty);
        }
    }
}
