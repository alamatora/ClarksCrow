using System;
using System.Collections.Generic;
using System.Drawing;
using Grasshopper.Kernel;
using ClarksCrow.Database;
using ClarksCrow.GH_Types;

namespace ClarksCrow.Components {
    public class ConstructUEVComponent : GH_Component {

        public ConstructUEVComponent() :
            base("Construct Unit Emergy Values", "UEVs", "Unit Emergy Value", "Clark's Crow", "1 | Setup") { } //TODO: Edit description

        protected override void RegisterInputParams(GH_InputParamManager pManager) {
            pManager.AddTextParameter("Name", "name", "Unique name for the Unit Emergy Value", GH_ParamAccess.item);
            pManager.AddNumberParameter("Value", "value", "Value associated with the UEV", GH_ParamAccess.item);
            pManager.AddTextParameter("Unit", "unit", "", GH_ParamAccess.item); //TODO: Add unit list to description
            pManager.AddNumberParameter("Geobiosphere Emergy Baseline [seJ per year]", "GEB", "Geobiosphere Emergy Baseline of the UEV", GH_ParamAccess.item);
            pManager.AddTextParameter("Reference", "ref", "Literature reference of the UEV", GH_ParamAccess.item);
        }

        protected override void RegisterOutputParams(GH_OutputParamManager pManager) {
            IGH_Param GH_UEV = new GH_Parameters.GH_UEV();
            pManager.AddParameter(GH_UEV, "Unit Emergy Values", "UEVs", "", GH_ParamAccess.item); //TODO: Add description
        }

        protected override void SolveInstance(IGH_DataAccess DA) {
            string i_Name = "";
            double i_Value = 0;
            string i_Unit = "";
            double i_GEB = 0;
            string i_Reference = "";

            //TODO: Add defaults and optional fields
            if (!DA.GetData(0, ref i_Name)) { return; }
            if (!DA.GetData(1, ref i_Value)) { return; }
            if (!DA.GetData(2, ref i_Unit)) { return; }
            if (!DA.GetData(3, ref i_GEB)) { return; }
            if (!DA.GetData(4, ref i_Reference)) { return; }

            UEV new_UEV = new UEV();
            new_UEV.Name = i_Name;
            new_UEV.Value = i_Value;
            Units parsedUnit; //TODO: Better parsing
            if (!Enum.TryParse(i_Unit, out parsedUnit)) {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, string.Format("\"{0}\" is not a supported unit", i_Unit));
                return;
            }
            new_UEV.Unit = parsedUnit;
            new_UEV.GeobiosphereEmergyBaseline = i_GEB;
            new_UEV.Reference = i_Reference;

            DA.SetData(0, new GH_UEVType(new_UEV));
        }

        #region Properties

        public override Guid ComponentGuid => new Guid("{3F3FD343-1337-4F76-A00B-44FD423E8EE1}");

        public override GH_Exposure Exposure => GH_Exposure.primary;

        protected override Bitmap Icon => base.Icon;

        #endregion
    }
}
