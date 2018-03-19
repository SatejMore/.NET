using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.ISP
{
    internal class Document
    {

    }//end of class Document

    internal interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }//end of interface IMachine


    internal class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            //Implementation
        }

        public void Print(Document d)
        {
            //Implementation
        }

        public void Scan(Document d)
        {
            //Implementation
        }
    }//end of class MultiFunctionPrinter


    internal class OldFashionedPrinter : IMachine
    {
        public void Fax(Document d)
        {
            //Implementation
        }

        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IPrint
    {
        void Print(Document d);
    }

    internal interface IScan
    {
        void Scan(Document d);
    }


    internal interface IMultiFunction : IPrint, IScan
    {
        void Fax(Document d);
    }

    internal class MultifunctionDevice : IMultiFunction
    {
        IScan _scanner;
        IPrint _printer;

        public MultifunctionDevice(IScan scanner, IPrint printer)
        {
            _scanner = scanner;
            _printer = printer;
        }

        public void Fax(Document d)
        {
            //
        }

        public void Print(Document d)
        {
            _printer.Print(d);
        }

        public void Scan(Document d)
        {
            _scanner.Scan(d);
        }
    }

    internal class ClsISP
    {
    }//end of class ClsISP

}//end of namespace SOLIDPrinciples.ISP
