using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    internal class Box
    {

        private float length;
        private float height;
        private float width;
        public Box(float length, float width, float height)
        {
            SetLength(length);
            SetHeight(height);
            SetWidth(width);
        }
        private void SetLength(float length)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Length should not be negative or zero");
            }
            this.length = length;
        }

        private void SetWidth(float width)
        {
            if (width <= 0)
            {
                throw new ArgumentException("Width should not be negative or zero");
            }
            this.width = width;
        }

        private void SetHeight(float height)
        {
            if (height <= 0)
            {
                throw new ArgumentException("Height should not be negative or zero");
            }
            this.height = height;
        }
        private float CalcSurfaceArea()
        {
            return (2 * length * width) + (2 * length * height) + (2 * width * height);
        }
        private float CalcLateralSurface()
        {
            return (2 * length * height) + (2 * width * height);
        }
        private float CalcVolume()
        {
            return length * width * height;
        }
        public override string ToString()
        {
            return String.Format("Surface Area : {0}\nLateral Surface : {1}\nVolume : {2}", CalcSurfaceArea(), CalcLateralSurface(), CalcVolume());
        }
    }
}

