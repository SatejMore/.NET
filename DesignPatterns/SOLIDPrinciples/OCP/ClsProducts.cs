using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OCP
{
    public enum Color { RED, GREEN, BLUE}

    public enum Size { SMALL, MEDIUM, LARGE, HUGE}

    internal class ClsProducts
    {
        public string Name;
        public Color Color;
        public Size Size;

        public ClsProducts(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }//end of ctor
            
    }//end of class ClsProducts

    internal class ProductFilter
    {
        internal IEnumerable<ClsProducts> FilterByColor(IEnumerable<ClsProducts> products, Color color)
        {
            foreach (var product in products)
            {
                if (product.Color == color)
                    yield return product;
            }//end of foreach
        }//end of function FilterByColor

        internal IEnumerable<ClsProducts> FilterBySize(IEnumerable<ClsProducts> products, Size size)
        {
            foreach (var product in products)
            {
                if (product.Size == size)
                    yield return product;
            }//end of foreach
        }//end of function FilterBySize

        internal IEnumerable<ClsProducts> FilterByColorAndSize(IEnumerable<ClsProducts> products, Color color, Size size)
        {
            foreach (var product in products)
            {
                if (product.Color == color && product.Size == size)
                    yield return product;
            }//end of foreach
        }//end of function FilterByColorAndSize

    }//end of class ProductFilter

}//end of namespace SOLIDPrinciples.OCP
