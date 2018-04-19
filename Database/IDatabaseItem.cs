using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarksCrow.Database {
    public interface IDatabaseItem {

        string Name { get; set; }
        int ClearNull();
    }
}
