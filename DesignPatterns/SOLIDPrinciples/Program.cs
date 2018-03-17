using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SOLIDPrinciples.SRP;
using SOLIDPrinciples.OCP;
using SOLIDPrinciples.LSP;

namespace SOLIDPrinciples
{
    class Program
    {
        static public int GetArea(Rectangle rec) => rec.Width* rec.Height;

        static void Main(string[] args)
        {
            #region SRP
            //ClsJournal objJournal = new ClsJournal();
            //objJournal.AddEntry("Hello Everyone");
            //objJournal.AddEntry("How are you?");
            //Console.WriteLine(objJournal.ToString());

            //ClsPersistence objPersistence = new ClsPersistence();
            //var fileName = "journal.txt";
            //objPersistence.SaveToFile(objJournal, fileName);
            //Process.Start(fileName);
            #endregion

            #region OCP
            //ClsProducts objProduct1 = new ClsProducts("Apple", Color.RED, Size.SMALL);
            //ClsProducts objProduct2 = new ClsProducts("Watermelon", Color.GREEN, Size.MEDIUM);
            //ClsProducts objProduct3 = new ClsProducts("Guvava", Color.GREEN, Size.MEDIUM);

            //ClsProducts[] productList = { objProduct1, objProduct2, objProduct3 };

            //ProductFilter objFilter = new ProductFilter();
            //Console.WriteLine("Green Products (Old):");
            //foreach(var product in objFilter.FilterByColor(productList, Color.GREEN))
            //{
            //    Console.WriteLine($"{product.Name} is Green");
            //}

            //Console.WriteLine("*****************After*******************");

            //BetterFilter bf = new BetterFilter();
            //Console.WriteLine("Green Products");
            //foreach (var prod in bf.Filter(productList,new ColorSpecification(Color.GREEN)))
            //{
            //    Console.WriteLine($"{prod.Name} is Green");
            //}//end of for each


            //Console.WriteLine("Small size products");
            //foreach (var prod in bf.Filter(productList, new SizeSpecification(Size.SMALL)))
            //{
            //    Console.WriteLine($"{prod.Name} is small in size");
            //}//end of foreach

            //Console.WriteLine("Green and Medium size products");

            //foreach (var prod in bf.Filter(productList,
            //    new AndSpecification(new ColorSpecification(Color.GREEN),new SizeSpecification(Size.MEDIUM))))
            //{
            //    Console.WriteLine($"{prod.Name} is green and medium");
            //}//end of foreach 
            #endregion

            #region LSP
            Rectangle rec = new Rectangle(2, 3);
            Console.WriteLine($"{rec} has area {GetArea(rec)}");

            Rectangle sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} has area {GetArea(sq)}");
            #endregion
        }
    }//end of class Program
}//end of namespace SOLIDPrinciples
