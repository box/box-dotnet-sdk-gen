namespace Unions {
    public class OneOf<T0> {
        protected T0 _val0 { get; }
        
        protected OneOf (T0 value) { _val0 = value; }
        
        public static implicit operator OneOf<T0>(T0 value) => new OneOf<T0>(value);
    }
}