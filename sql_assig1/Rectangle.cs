using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_assig1
{
    public class Rectangle
    {
        private int rect_length;
        private int rect_width;
        public Rectangle()
        {
            rect_length = 1;
            rect_width = 1;
        }
        public Rectangle(int rect_length, int rect_width)
        {
            this.rect_length = rect_length;
            this.rect_width = rect_width;
        }
        public int GetLength()
        {
            return this.rect_length;
        }
        public int SetLength(int rect_length)
        {
            this.rect_length = rect_length;
            return this.rect_length;
        }
        public int GetWidth()
        {
            return this.rect_width;
        }
        public int SetWidth(int rect_width)
        {
            this.rect_width = rect_width;
            return this.rect_width;
        }
        public int GetPerimeter()
        {
            return 2 * (rect_length + rect_width);
        }
        public int GetArea()
        {
            return rect_length * rect_width;
        }
    }
}
