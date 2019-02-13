using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1302
{
    class MyButton
    {
        protected Point topLeft;
        protected Point bottomRight;

        private int width, height;

        internal MyButton(Point topLeft,Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }

        internal int GetWidth()
        {
            return this.width;
        }

        internal int GetHeight()
        {
            return this.height;

        }

        internal bool SetTopLeft (Point p)
        {
            if ((p.GetX() < this.bottomRight.GetX()) && (p.GetY() > this.bottomRight.GetY())) 
            {
                this.topLeft = p;
                this.height = 5;
                this.width = 5;
                return true;
            }

            else 
            {
                Console.WriteLine("Point is not on the top left of Button");
                return false;
            }
        }

        internal bool SetBottomRight (Point p)
        {
            if ((p.GetX() > this.topLeft.GetX()) && (p.GetY() < this.topLeft.GetY()))
            {
                this.bottomRight = p;
                this.height = 5;
                this.width = 5;
                return true;
            }

            else
            {
                Console.WriteLine("Point is not on the bottom right of Button");
                return false;
            }
        }

        internal Point GetTopLeft()
        {
            return topLeft;
        }

        internal Point GetBottomRight()
        {
            return bottomRight;
        }

        public override string ToString()
        {
            return $"Width {this.width}, Height {this.height}, Top Point {this.topLeft}, Bottom Right {this.bottomRight}";
        }

    }
}
