using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SOLIDPrinciples.SRP
{
    internal class ClsJournal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        internal int AddEntry(string text)
        {
            entries.Add($"{++count}:{text}");
            return count;
        }//end of function AddEntry

        internal void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }//end of function RemoveEntry

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }//end of method ToString()

        //Violets the Single Responsibility Principle
        internal void Save(string fileName, bool overwrite=false)
        {
            File.WriteAllText(fileName, ToString());
        }//end of function Save

        internal void Load(string filePath)
        {

        }//end of function Load

        internal void Load(Uri uri)
        {

        }//end of function Load

    }//end of class ClsSRPProblem

    /*
    Solution: Create new class and give the class responsibility to store the data in file
    */
    internal class ClsPersistence
    {
        internal void SaveToFile(ClsJournal objJournal, string fileName, bool overwrite = false)
        {
            if(overwrite || !File.Exists(fileName))
            {
                File.WriteAllText(fileName, objJournal.ToString());
            }//end of if
        }//end of function SaveToFile

    }//end of class ClsPersistence

}//end of namespace SOLIDPrinciples.SRP
