using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClarksCrow.Database;

namespace ClarksCrow {
    public static class Global {

        public static double DocumentGeobiosphereEmergyBaseline { get; set; }

        public static List<MaterialFamily> MaterialDatabase = new List<MaterialFamily>();
        public static List<UEV> UEVDatabase = new List<UEV>();
    }
}
