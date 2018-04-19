using System;
using System.Collections.Generic;
using System.Drawing;
using Grasshopper.Kernel;
using ClarksCrow.Database;
using ClarksCrow.GH_Types;

namespace ClarksCrow.Components {
    public class DeconstructUEVComponent : GH_Component {

        public DeconstructUEVComponent() :
            base("Deconstruct Unit Emergy Values", "UEVs", "Unit Emergy Value", "Clark's Crow", "1 | Setup") { } //TODO: Edit description

        protected override void RegisterInputParams(GH_InputParamManager pManager) {
            IGH_Param GH_UEV = new GH_Parameters.GH_UEV();
            pManager.AddParameter(GH_UEV, "Unit Emergy Values", "UEVs", "", GH_ParamAccess.item); //TODO: Add description
        }

        protected override void RegisterOutputParams(GH_OutputParamManager pManager) {
            pManager.AddTextParameter("Name", "name", "Unique name of the Unit Emergy Value", GH_ParamAccess.item);
            pManager.AddNumberParameter("Value", "value", "Value associated with the UEV", GH_ParamAccess.item);
            pManager.AddTextParameter("Unit", "unit", "", GH_ParamAccess.item); //TODO: Add unit list to description
            pManager.AddNumberParameter("Geobiosphere Emergy Baseline [seJ per year]", "GEB", "Geobiosphere Emergy Baseline of the UEV", GH_ParamAccess.item);
            pManager.AddTextParameter("Reference", "ref", "Literature reference of the UEV", GH_ParamAccess.item);
        }

        protected override void SolveInstance(IGH_DataAccess DA) {
            GH_UEVType i_GH_UEV = null;

            if (!DA.GetData(0, ref i_GH_UEV) || i_GH_UEV == null) { return; }

            UEV i_UEV = i_GH_UEV.Value;

            DA.SetData(0, i_UEV.Name);
            DA.SetData(1, i_UEV.Value);
            DA.SetData(2, i_UEV.Unit.ToString());
            DA.SetData(3, i_UEV.GeobiosphereEmergyBaseline);
            DA.SetData(4, i_UEV.Reference);
        }

        #region Properties

        public override Guid ComponentGuid => new Guid("{B4C6246B-8872-4263-B51E-0E4FC2672834}");

        public override GH_Exposure Exposure => GH_Exposure.secondary;

        protected override Bitmap Icon => base.Icon;

        #endregion
    }
}
