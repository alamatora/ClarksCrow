using System.Collections;
using System.Collections.Generic;

namespace ClarksCrow.Database {
    public class DatabaseNameComparer : IComparer<IDatabaseItem> {

        CaseInsensitiveComparer caseiComp = new CaseInsensitiveComparer();

        public int Compare(IDatabaseItem x, IDatabaseItem y) {
            return caseiComp.Compare(x.Name, y.Name);
        }
    }
}
