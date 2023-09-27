using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdaStorage.Models
{
    public class Mob
    {
        public int Id { get; }
        public string Name { get; }
        public int Quantity { get; }
        public bool IsArchi { get; }

        public Mob(int id, string name, int quantity, bool isArchi = false)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            IsArchi = isArchi;
        }
    }
}
