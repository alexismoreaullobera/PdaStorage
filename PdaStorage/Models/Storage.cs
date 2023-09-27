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
            return pdaResult?.GetMobs();
        }

        public IEnumerable<Pda> GetPdas()
        {
            return _pdaNameToPda.Values;
        }

        public void AddPda(Pda pda)
        {
            if(pda is null)
            {
                throw new ArgumentNullException(nameof(pda));
            }

            _pdaNameToPda.TryAdd(pda.Name, pda);
        }
    }
}
