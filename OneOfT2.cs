namespace Unions {
    public class OneOf<T0,T1> {
        protected T0? _val0 { get; }
        
        protected T1? _val1 { get; }
        
        protected OneOf (T0 value) { _val0 = value; }
        
        protected OneOf (T1 value) { _val1 = value; }
        
        public static implicit operator OneOf<T0,T1>(T0 value) => new OneOf<T0,T1>(value);
        
        public static implicit operator OneOf<T0,T1>(T1 value) => new OneOf<T0,T1>(value);
    }
}