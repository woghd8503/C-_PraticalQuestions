using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle
    {
        private double width;
        private double height;

        public double GetWidth()        // Getter
        {
            return width;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetWidth(double width)  // Setter
        {
            if (width > 0)
                this.width = width;
        }

        public void SetHeight(double height)
        {
            if (height > 0)
                this.height = height;
        }
    }

    class RectWithProp
    {
        public double Width { get; set; } // Width 속성
        public double Height { get; set; }  // Height 속성
    }

    class RectWithPropFull
    {
        private double width;

        public double Width
        {
            get { return width; }
            set { if (value > 0) width = value; }
        }
    }
}


