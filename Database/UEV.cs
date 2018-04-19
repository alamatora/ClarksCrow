namespace ClarksCrow.Database {
    public class UEV : IDatabaseItem {

        public string Name { get; set; }
        public double Value { get; set; }
        public Units Unit { get; set; }
        public double GeobiosphereEmergyBaseline { get; set; }
        public string Reference { get; set; }

        public UEV() {
            Name = "Unnamed UEV";
            Value = 0;
            Unit = Units.J;
            GeobiosphereEmergyBaseline = Global.DocumentGeobiosphereEmergyBaseline;
            Reference = "";
        }

        public UEV(UEV source) {
            Name = source.Name;
            Unit = source.Unit;
            Value = source.Value;
            GeobiosphereEmergyBaseline = source.GeobiosphereEmergyBaseline;
            Reference = source.Reference;
        }

        public double ValueToDocumentGEB() => Value * (Global.DocumentGeobiosphereEmergyBaseline / GeobiosphereEmergyBaseline);

        public int ClearNull() {
            //TODO: Implement
            return 0;
        }
    }
}
