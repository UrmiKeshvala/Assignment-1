using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSENG8040_1
{
    public class Rectangle
    {
        private int RecLength;
        private int RecWidth;

        public Rectangle()
        {
            RecLength = 1;
            RecWidth = 1;
        }

        public Rectangle(int RecLength, int RecWidth)
        {
            this.RecLength = RecLength;
            this.RecWidth = RecWidth;

        }
        public int GetRecLength()
        {

            return RecLength;
        }

        public int SetRecLength(int RecLength)
        {

            this.RecLength = RecLength;
            return this.RecLength;

        }

        public int GetRecWidth()
        {

            return RecWidth;
        }

        public int SetRecWidth(int RecWidth)
        {
            this.RecWidth = RecWidth;
            return this.RecWidth;
        }

        public int GetPerimeter()
        {
            return (RecWidth * 2) + (RecLength * 2);

        }

        public int GetArea()
        {
            return RecLength * RecWidth;
        }
    }
}
