using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdaStorage.Models
{
    public class Owner
    {
        private readonly Storage _storage;
        public string Name { get;}

        public Owner(string name)
        {
            Name = name;

            _storage = new Storage();
        }

    }
}
