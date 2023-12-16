using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAwesomeDictionary
{
    public class Key
    {
        public string Id { get; }

        public Key(string id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.Count();
        }
    }
}
