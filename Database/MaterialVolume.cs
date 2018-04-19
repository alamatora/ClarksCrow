using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarksCrow.Database {
    public class MaterialVolume : IMaterialInstance  {

        public MaterialFamily Family { get; set; }
        public string Name { get; set; }
        public double Ratio { get; set; }
        public List<UEV> MaterialUEVs { get; set; }
        public List<UEV> TransportationUEVs { get; set; }
        public List<UEV> ServicesUEVs { get; set; }
        public List<UEV> EnergyUEVs { get; set; }

        public MaterialVolume() {
            SetToDefault();
        }

        public MaterialVolume(MaterialFamily family) {
            SetToDefault();
            Family = family;
            family.MaterialInstances.Add(this);
        }

        public int ClearNull() {
            int n = 0;
            n += MaterialUEVs.RemoveAll(item => item == null);
            n += TransportationUEVs.RemoveAll(item => item == null);
            n += ServicesUEVs.RemoveAll(item => item == null);
            n += EnergyUEVs.RemoveAll(item => item == null);
            return n;
        }

        //TODO: Add method to interface or base class?
        private void SetToDefault() {
            Name = "Unnamed Material Volume";
            Family = null;
            Ratio = 1;
            MaterialUEVs = new List<UEV>();
            TransportationUEVs = new List<UEV>();
            ServicesUEVs = new List<UEV>();
        }
    }
}
