using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedOfBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Hello";
            string[] orderList = {"Order1","Order2","Order3"};

            StringBuilder builder = new StringBuilder();
            builder.Append("<p>");
            builder.Append(name);
            builder.Append("</p>");

            Console.WriteLine(builder);

            builder.Clear();

            builder.Append("<ul>");
            foreach (var order in orderList)
            {
                builder.Append($"<li>{order}</li>");
            }
            builder.Append("</ul>");
            Console.WriteLine(builder);

        }
    }//end of class Program
}//end of namespace NeedOfBuilder
