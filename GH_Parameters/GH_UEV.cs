using System;
using System.Collections.Generic;
using Grasshopper.Kernel;
using ClarksCrow.GH_Types;
using System.Drawing;

namespace ClarksCrow.GH_Parameters {
    public class GH_UEV : GH_PersistentParam<GH_UEVType> {

        public GH_UEV() :
            base("Unit Emergy Values", "UEVs", "Contains a collection of Unit Emergy Values", "Clark's Crow", "0 | Clark's Crow") { }
        
        protected override GH_GetterResult Prompt_Plural(ref List<GH_UEVType> values) {
            throw new NotImplementedException();
        }

        protected override GH_GetterResult Prompt_Singular(ref GH_UEVType value) {
            throw new NotImplementedException();
        }

        #region Properties

        public override Guid ComponentGuid => new Guid("{56FB3E6C-441E-42C0-9134-DA323CC2B600}");

        public override GH_Exposure Exposure => GH_Exposure.secondary;

        protected override Bitmap Icon => base.Icon;

        #endregion
    }
}
