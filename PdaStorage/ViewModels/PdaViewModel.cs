using PdaStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdaStorage.ViewModels
{
    public class PdaViewModel : ViewModelBase
    {
        private readonly Pda _pda;

        public int Id => _pda.Id;
        public string Name => _pda.Name;
        public int PdaCount => _pda.PdaCount;
        public int MobCount => _pda.MobCount;

        public PdaViewModel(Pda pda)
        {
            _pda = pda;
        }
    }
}
