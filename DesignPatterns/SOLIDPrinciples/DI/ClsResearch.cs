using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.DI
{
    internal enum Relation
    {
        Parent,
        Child,
        Siblings
    }

    internal class Person
    {
        public string Name { get; set; }
        //public DateTime DateOfBirth { get; set; }
    }//end if class Person


    internal interface IRelationship
    {
        IEnumerable<Person> FindChildrensOf(string Name);

    }//end of interface IRelationship

    internal class Relationships  : IRelationship
    {
        private List<Tuple<Person,Relation,Person>> relations = new List<Tuple<Person,Relation,Person>>();
        
        public void AddParentChild(Person parent, Person child)
        {
            relations.Add(new Tuple<Person, Relation, Person>(parent, Relation.Parent, child));
            relations.Add(new Tuple<Person, Relation, Person>(child, Relation.Child, parent));
        }//end of method AddParentChild

        public IEnumerable<Person> FindChildrensOf(string name)
        {
            return relations.Where(e => e.Item1.Name == name && e.Item2 == Relation.Parent).Select(e => e.Item3);
        }//end of function 

        //public List<Tuple<Person, Relation, Person>> Relations => relations;
    }//end of class Relationships

    internal class ClsResearch
    {
        public ClsResearch(IRelationship relationships,string name)
        {
            foreach (var r in relationships.FindChildrensOf(name))
            {
              
                    Console.WriteLine($"Rajiv has child with name {r.Name}");
            }
        }//end of ctor
    }//end of class ClsResearch
}//end of namespace SOLIDPrinciples.DI
