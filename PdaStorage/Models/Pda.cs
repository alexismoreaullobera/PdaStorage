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
        public int PdaCount { get => _mobIdToMob.Count; }
        public int MobCount { get; private set; }

        public Pda(string name)
        {
            Name = name;

            _mobIdToMob = new Dictionary<int, Mob>();
        }

        public void AddMob(Mob mob)
        {
            if(mob is null)
            {
                throw new ArgumentNullException(nameof(mob));
            }

            if(_mobIdToMob.TryAdd(mob.Id, mob))
            {
                _mobIdToMob[mob.Id] = mob;
            }

            ++MobCount;
        }

        public IEnumerable<Mob> GetMobs()
        {
            return _mobIdToMob.Values;
        }
    }
}
