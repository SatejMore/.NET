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


    /*Solution Apply OCP in the following way*/

    internal interface ISpecification<T>
    {
        bool IsSatisfied(T t);

    }//end of interface ISpecification


    internal interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> t, ISpecification<T> Spec);
    }//end of interface IFilter

    internal class ColorSpecification : ISpecification<ClsProducts>
    {
        Color _color;
        public ColorSpecification(Color color)
        {
            _color = color;
        }

        public bool IsSatisfied(ClsProducts t)
        {
            return  t.Color == _color;
        }//end of function IsSatisfied
    }//end of class ColorSpecification


    internal class SizeSpecification : ISpecification<ClsProducts>
    {
        Size _size;
        public SizeSpecification(Size size)
        {
            _size = size;
        }//end of constructor

        public bool IsSatisfied(ClsProducts prod)
        {
            return prod.Size == _size;
        }//end of function IsSatisfied
    }//end of class SizeSpecification

    //Combinator
    internal class AndSpecification : ISpecification<ClsProducts>
    {
        ISpecification<ClsProducts> _first, _second;

        public AndSpecification(ISpecification<ClsProducts> first, ISpecification<ClsProducts> second)
        {
            _first = first;
            _second = second;
        }

        public bool IsSatisfied(ClsProducts prod)
        {
            return _first.IsSatisfied(prod) && _second.IsSatisfied(prod);
        }//end of function IsSatisfied

    }//end of class AndSpecification

    internal class BetterFilter : IFilter<ClsProducts>
    { 
        public IEnumerable<ClsProducts> Filter(IEnumerable<ClsProducts> prodList, ISpecification<ClsProducts> Spec)
        {
            foreach (var prod in prodList)
            {
                if(Spec.IsSatisfied(prod))
                    yield return prod;
            }//end of foreach
        }//end of function Filter 

    }//end of class BetterFilter

}//end of namespace SOLIDPrinciples.OCP
