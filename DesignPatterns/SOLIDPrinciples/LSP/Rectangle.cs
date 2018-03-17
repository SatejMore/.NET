using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LSP
{
    internal class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public Rectangle()
        {

        }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}:{Width},{nameof(Height)}:{Height}";
        }
    }//end of class Rectangle

    internal class Square : Rectangle
    {
        //public new int Width
        //{
        //    set { base.Width = base.Height = value; }
        //}

        //public new int Height
        //{
        //    set { base.Height = base.Width = value; }
        //}

        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Height = base.Width = value; }
        }
    }
}//end of namespace SOLIDPrinciples.LSP
