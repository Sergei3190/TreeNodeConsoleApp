using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeNodeConsoleApp
{
    class Subdivision
    {  
        public string Name { get; set; }
        public string Number { get; set; }
        public List<Subdivision> ChildSubdiv { get; set; } = new List<Subdivision>();
        public Subdivision() { }

        public Subdivision(string name, string number, params Subdivision[] childSubdiv)
        {
            Name = name;
            Number = number;
            ChildSubdiv = childSubdiv.ToList();
        }

        public override string ToString() => $" {nameof(Name)}: {Name}," +
                                             $" {nameof(Number)}: {Number}," +
                                             $" {nameof(ChildSubdiv)}: {ChildSubdiv.Count}";      
    }
}
