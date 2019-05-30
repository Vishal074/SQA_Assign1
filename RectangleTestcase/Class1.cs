using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sql_assig1;
using NUnit.Framework;

namespace RectangleTestcase
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test_GetLength()
        {
            int len = 4;
            int wid = 5;
            Rectangle testRect = new Rectangle(len, wid);
            int l = testRect.GetLength();
            Assert.AreEqual(l, len);
        }
        [Test]
        public void Test_GetWidth()
        {
            int len = 4;
            int wid = 5;
            Rectangle testRect = new Rectangle(len, wid);
            int w = testRect.GetWidth();
            Assert.AreEqual(w, wid);
        }
        [Test]
        public void Test_SetLength()
        {
            int len = 999;
            Rectangle rectangle = new Rectangle();
            int l = rectangle.SetLength(len);
            Assert.AreEqual(l, len);
        }
        [Test]
        public void Test_SetWidth()
        {
            int wid = 59;
            Rectangle rectangle = new Rectangle();
            int w = rectangle.SetWidth(wid);
            Assert.AreEqual(w, wid);
        }
        [Test]
        public void Test_GetPerimeter()
        {
            int len = 50, wid = 60;
            Rectangle rectangle = new Rectangle(len, wid);
            int answer = rectangle.GetPerimeter();
            Assert.AreEqual(answer, (2 * (len + wid)));
        }
        [Test]
        public void Test_GetArea()
        {
            int len = 50, wid = 60;
            Rectangle rectangle = new Rectangle(len, wid);
            int answer = rectangle.GetArea();
            Assert.AreEqual(answer, (len * wid));
        }
    }
}