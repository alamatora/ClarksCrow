using System.Collections.Generic;

namespace ClarksCrow.Database {
    public class MaterialFamily : IDatabaseItem {

        public string Name { get; set; }
        public double Density { get; set; } //In kg/m3
        public List<IMaterialInstance> MaterialInstances { get; set; }

        public MaterialFamily() {
            Name = "Unnamed Material Family";
            Density = 0;
            MaterialInstances = new List<IMaterialInstance>();
        }

        public int ClearNull() {
            return MaterialInstances.RemoveAll(item => item == null);
        }
    }
}
