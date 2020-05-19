using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerContracts.Entities
{
    class Depatarment
    {
        public string Name { get; set; }

        public Depatarment()
        {
        }

        public Depatarment(string name)
        {
            Name = name;
        }
    }
}
