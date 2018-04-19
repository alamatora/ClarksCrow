using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarksCrow.Database {
    public interface IMaterialInstance : IDatabaseItem {

        MaterialFamily Family { get; set; }
        double Ratio { get; set; }
        List<UEV> MaterialUEVs { get; set; }
        List<UEV> TransportationUEVs { get; set; }
        List<UEV> ServicesUEVs { get; set; }
        List<UEV> EnergyUEVs { get; set; }
    }
}
