using Grasshopper.Kernel.Types;
using ClarksCrow.Database;

namespace ClarksCrow.GH_Types {
    public class GH_UEVType : GH_Goo<UEV> {

        public GH_UEVType() : base() { }
        public GH_UEVType(UEV source) : base(source) { }

        public override bool IsValid => true;

        public override string TypeName => "UEV";

        public override string TypeDescription => "Unit Emergy Value";

        public override IGH_Goo Duplicate() {
            UEV copy = new UEV(Value);
            return new GH_UEVType(copy);
        }

        public override string ToString() {
            return string.Format("[UEV] {0} ({1})", Value.Name, Value.Unit);
        }
    }
}
