using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdaStorage.Models
{
    public class Pda
    {
        private readonly Dictionary<int, Mob> _mobIdToMob;

        public string Name { get; }
        public int Count { get => _mobIdToMob.Count; }
        public List<Mob> Mobs { get  => _mobIdToMob.Values.ToList(); }

        public Pda(string name)
        {
            Name = name;

            _mobIdToMob = new Dictionary<int, Mob>();
        }
    }
}
