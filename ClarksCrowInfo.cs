using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace ClarksCrow {
    public class ClarksCrowInfo : GH_AssemblyInfo {
        public override string Name => "Clark's Crow";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("{A734E389-1490-4A6A-A1E6-B9BFC0FDB4CE}");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}
