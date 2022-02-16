using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public abstract class Pizza
    {
        public string Prepare()
        {
            return $"${GetType()} - preparing pizza...";
        }

        public string Bake()
        {
            return $"${GetType()} - baking pizza...";
        }

        public string Cut()
        {
            return $"${GetType()} - cutting pizza...";
        }

        public string Box()
        {
            return $"${GetType()} - boxing pizza...";
        }
    }
}
