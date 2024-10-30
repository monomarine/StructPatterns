using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class FacadeToAssembly
    {
        private  Blueprint _blueprint;
        private  Sawed _sawed;
        private  Assembling _assembling;

        public void InitProduction(string title)
        {
            _blueprint = new Blueprint(title);
            _sawed = new Sawed(title);
            _assembling = new Assembling(title);

            _blueprint.Show();
            _sawed.Show();
            _assembling.Show();
        }

        public void StartProduction(string title)
        {
            InitProduction(title);

            _blueprint.ReadyToWork();
            _sawed.AcceptedToWork();
            _assembling.AcceptedToAssembly();
        }

        public void StopProduction() 
        {
            _blueprint.Postponed();
            _sawed.GetBlanks();
            _assembling.GetFinishedProduct();
        }
    }
}
