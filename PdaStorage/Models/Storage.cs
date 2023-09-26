using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdaStorage.Models
{
    public class Storage
    {
        private readonly Dictionary<string, Pda> _pdaNameToPda;

        public int Count { get => _pdaNameToPda.Count; }

        public Storage()
        {
            _pdaNameToPda = new Dictionary<string, Pda>(); 
        }

        public IEnumerable<Mob>? GetMobsByPdaName(string name)
        {
            _pdaNameToPda.TryGetValue(name, out Pda pdaResult);
            return pdaResult?.Mobs;
        }
    }
}
