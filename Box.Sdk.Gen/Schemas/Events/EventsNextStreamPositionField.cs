using Unions;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class EventsNextStreamPositionField : OneOf<string, double> {
        public string? StringVal => _val0;
        
        public double? DoubleVal => _val1;
        
        public EventsNextStreamPositionField(string value) : base(value) {}
        
        public EventsNextStreamPositionField(double value) : base(value) {}
        
        public static implicit operator EventsNextStreamPositionField(string value) => new EventsNextStreamPositionField(value);
        
        public static implicit operator EventsNextStreamPositionField(double value) => new EventsNextStreamPositionField(value);
    }
}