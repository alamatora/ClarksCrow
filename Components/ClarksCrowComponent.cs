using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grasshopper.Kernel;

namespace ClarksCrow.Components {
    public class ClarksCrowComponent : GH_Component {

        public ClarksCrowComponent() :
            base("Clark's Crow", "CC", "This component carries all of Clark’s Crow’s main classes including the Unit Emergy Values (UEVs). Other components refer to these classes to run the studies therefore you need to run this component before running the studies so that classes will be copied to Rhinos shared space.\n\nClark’s Crow: A Plugin for Emergy Evaluation started by Naomi Keena, Mohamed Aly, and Δaniel Ruan. You should have received a copy of the GNU General Public License along with Honeybee; If not, see <http://gnu.org/licenses/>.\n@license GLP-3.0+<http://spdx.org/licenses/GLP-3.0+>\nSource code is available at: https://github.com/RPI-CASE/Clark-sCrow-tool_tool\n-\nProvided by Clark’s Crow 0.0.01", "Clark's Crow", "0 | Clark's Crow") { }

        protected override void RegisterInputParams(GH_InputParamManager pManager) {
            pManager.AddNumberParameter("Geobiosphere Emergy Baseline [seJ per year]", "GEB", "Geobiosphere Emergy Baseline applied to all emergy simulations in this file. Defaults to 12E+24 seJ.\n\nGeobiosphere Emergy Baseline (also known as the Emergy Global Baseline)\nThe geobiosphere is driven by three sources, the available energy from solar radiation, geothermal sources and dissipation of  tidal momentum. Together they make up the geobiosphere emergy baseline (GEB) which is a specified uniform solar equivalent exergy reference required to calculate consistent emergy values.  The premise being that if emergy practitioners reference their work to a single agreed-upon baseline, then all research products resulting from the application of emergy analysis will be inherently consistent and valid comparisons can be made.\n(Sources: Brown, M. T., Campbell, D. E., De Vilbiss, C., & Ulgiati, S. (2016). The geobiosphere emergy baseline: a synthesis. Ecological Modelling, 339, 92-95; Brown, M. T., & Ulgiati, S. (2016). Assessing the global environmental sources driving the geobiosphere: a revised emergy baseline. Ecological Modelling, 339, 126-132.)", GH_ParamAccess.item, 12E+24);   //Defaults to Brown et al, 2016
        }

        protected override void RegisterOutputParams(GH_OutputParamManager pManager) {
            pManager.AddTextParameter("Out", "out", "Output Log", GH_ParamAccess.item);
        }

        protected override void SolveInstance(IGH_DataAccess DA) {
            double GEB = 0;
            if(DA.GetData(0, ref GEB)) {
                Global.DocumentGeobiosphereEmergyBaseline = GEB;
            }

            string log = String.Format("Document Geobiosphere Emergy Baseline: {0} seJ/year", Global.DocumentGeobiosphereEmergyBaseline.ToString("0.00E0"));
            DA.SetData(0, log);
        }

        private void ManageDatabase(object sender, EventArgs e) {
            Database.DatabaseManager form = new Database.DatabaseManager();
            form.TopMost = true;
            form.Show();
        }

        #region Properties
        public override Guid ComponentGuid => new Guid("{7DD548C3-8FED-48DC-89E4-7E284F72A2C7}");

        public override GH_Exposure Exposure => GH_Exposure.primary;

        protected override Bitmap Icon => base.Icon;

        protected override void AppendAdditionalComponentMenuItems(ToolStripDropDown menu) {
            base.AppendAdditionalComponentMenuItems(menu);

            Menu_AppendItem(menu, "Manage Database", ManageDatabase);
        }

        #endregion
    }
}
