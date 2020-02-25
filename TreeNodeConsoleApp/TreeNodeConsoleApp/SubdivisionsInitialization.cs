using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeNodeConsoleApp
{
    class SubdivisionsInitialization
    {
        public static Subdivision FillSubdivisions()
        {
            Subdivision subdivision = new Subdivision
            {
                Name = "Подразделение",
                Number = "1",
                ChildSubdiv = new List<Subdivision>
                {
                    new Subdivision
                    {
                        Name = "Подразделение",
                        Number = "1.1",
                        ChildSubdiv = new List<Subdivision>
                        {
                            new Subdivision
                            {
                                Name = "Подразделение",
                                Number = "1.1.1",
                                ChildSubdiv = new List<Subdivision>
                                {
                                    new Subdivision
                                    {
                                        Name = "Подразделение",
                                        Number = "1.1.1.1",
                                        ChildSubdiv = new List<Subdivision>
                                        {
                                            new Subdivision { Name = "Подразделение", Number = "1.1.1.1.1" }
                                        }
                                    }
                                }
                            },
                            new Subdivision{ Name = "Подразделение", Number = "1.1.2"},
                            new Subdivision
                            {
                                Name = "Подразделение",
                                Number = "1.1.3",
                                ChildSubdiv = new List<Subdivision>
                                {
                                    new Subdivision { Name = "Подразделение", Number = "1.1.3.1"}
                                }
                            }
                        }
                    },
                    new Subdivision
                    {
                        Name = "Подразделение",
                        Number = "1.2"
                    }
                }
            };

            return subdivision;
        }
    }
}
