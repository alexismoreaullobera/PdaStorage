using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdaStorage.Models
{
    public class Pda
    {
        private static int _offsetId;
        private readonly List< Mob> _mobs;

        public int Id { get; }
        public string Name { get; }
        public int PdaCount { get => _mobs.Count; }
        public int MobCount { get; private set; }

        public Pda(string name)
        {
            Name = name;
            Id = ++_offsetId;

            _mobs = new List<Mob>();
        }

        public void AddMob(Mob mob)
        {
            if(mob is null)
            {
                throw new ArgumentNullException(nameof(mob));
            }

            _mobs.Add(mob);
        }

        public IEnumerable<Mob> GetMobs()
        {
            return _mobs;
        }
    }
}
