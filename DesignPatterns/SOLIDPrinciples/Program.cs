using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SOLIDPrinciples.SRP;
using SOLIDPrinciples.OCP;

namespace SOLIDPrinciples
{
    class Program
    {
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
            ClsProducts objProduct1 = new ClsProducts("Apple", Color.RED, Size.MEDIUM);
            ClsProducts objProduct2 = new ClsProducts("Watermelon", Color.GREEN, Size.MEDIUM);
            ClsProducts objProduct3 = new ClsProducts("Guvava", Color.GREEN, Size.MEDIUM);

            ClsProducts[] productList = { objProduct1, objProduct2, objProduct3 };

            ProductFilter objFilter = new ProductFilter();
            Console.WriteLine("Green Products (Old):");
            foreach(var product in objFilter.FilterByColor(productList, Color.GREEN))
            {
                Console.WriteLine($"{product.Name} is Green");
            } 
            #endregion
        }
    }//end of class Program
}//end of namespace SOLIDPrinciples
